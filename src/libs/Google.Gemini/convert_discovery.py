#!/usr/bin/env python3
"""Convert Google Discovery format to OpenAPI 3.0.3 format."""

import json
import re
import sys


def convert_ref(ref):
    """Convert Discovery $ref to OpenAPI $ref."""
    if ref and not ref.startswith("#"):
        return f"#/components/schemas/{ref}"
    return ref


def convert_schema(schema):
    """Recursively convert a Discovery schema to OpenAPI schema."""
    if not isinstance(schema, dict):
        return schema

    result = {}
    for key, value in schema.items():
        if key == "id":
            continue
        elif key == "$ref":
            result["$ref"] = convert_ref(value)
        elif key == "items":
            result["items"] = convert_schema(value)
        elif key == "properties":
            # Skip _prefixed properties when a non-prefixed variant exists
            # (Google Discovery uses these as internal aliases that collide
            #  in generated code after case conversion)
            prop_names = set(value.keys())
            result["properties"] = {
                k: convert_schema(v)
                for k, v in value.items()
                if not (k.startswith("_") and k[1:] in prop_names)
            }
        elif key == "additionalProperties":
            result["additionalProperties"] = convert_schema(value) if isinstance(value, dict) else value
        elif key == "enumDescriptions":
            result["x-enum-descriptions"] = value
        elif key == "variant":
            if "discriminant" in value:
                result["discriminator"] = {"propertyName": value["discriminant"]}
                if "map" in value:
                    result["discriminator"]["mapping"] = {
                        item["type_value"]: convert_ref(item["$ref"])
                        for item in value["map"]
                    }
        elif key == "type" and value == "any":
            pass  # omit type to allow any value
        elif key == "readOnly" or key == "deprecated":
            result[key] = value
        else:
            result[key] = value

    return result


def extract_methods(resources, version_prefix, paths=None):
    """Recursively extract methods from Discovery resources into OpenAPI paths."""
    if paths is None:
        paths = {}

    for resource_name, resource in (resources or {}).items():
        for method_name, method in (resource.get("methods") or {}).items():
            raw_path = method.get("flatPath") or method["path"]
            # Strip version prefix
            if raw_path.startswith(version_prefix):
                raw_path = raw_path[len(version_prefix):]
            path = "/" + raw_path
            # Convert {+param} to {param} (if flatPath wasn't available)
            path = re.sub(r"\{\+(\w+)\}", r"{\1}", path)

            http_method = method["httpMethod"].lower()

            operation = {}
            if "description" in method:
                operation["description"] = method["description"]

            # Build operationId from Discovery id
            full_id = method.get("id", f"{resource_name}.{method_name}")
            operation["operationId"] = full_id.replace("generativelanguage.", "")

            # Parameters
            params = []
            path_param_names = set(re.findall(r"\{(\w+)\}", path))
            # Track which path template params have been matched
            matched_path_params = set()
            for param_name, param in sorted((method.get("parameters") or {}).items()):
                p = {"name": param_name, "in": param["location"]}
                if param["location"] == "path":
                    if param_name in path_param_names:
                        matched_path_params.add(param_name)
                    else:
                        # Try to match Discovery param to flatPath param
                        # e.g., Discovery "model" → flatPath "{modelsId}"
                        unmatched = path_param_names - matched_path_params
                        if unmatched:
                            mapped = min(unmatched)  # deterministic: alphabetically first
                            p["name"] = mapped
                            matched_path_params.add(mapped)
                        else:
                            # Path param not in template — skip it
                            continue
                if param.get("required"):
                    p["required"] = True
                if "description" in param:
                    p["description"] = param["description"]

                schema = {}
                for sk in ("type", "format", "enum", "pattern", "default"):
                    if sk in param:
                        schema[sk] = param[sk]
                if param.get("repeated"):
                    p["schema"] = {"type": "array", "items": schema}
                else:
                    p["schema"] = schema
                params.append(p)

            # Ensure all path template params have definitions
            defined = {p["name"] for p in params}
            for pp in sorted(path_param_names):
                if pp not in defined:
                    params.insert(0, {
                        "name": pp,
                        "in": "path",
                        "required": True,
                        "schema": {"type": "string"},
                    })

            if params:
                operation["parameters"] = params

            # Request body
            if "request" in method:
                ref = method["request"].get("$ref")
                if ref:
                    operation["requestBody"] = {
                        "content": {
                            "application/json": {
                                "schema": {"$ref": convert_ref(ref)}
                            }
                        }
                    }

            # Response
            resp = {"200": {"description": "Successful response"}}
            if "response" in method:
                ref = method["response"].get("$ref")
                if ref:
                    schema = {"$ref": convert_ref(ref)}
                    resp["200"]["content"] = {
                        "application/json": {"schema": schema}
                    }
                    # Add SSE streaming for methods with "stream" in the name
                    if "stream" in method_name.lower():
                        resp["200"]["content"]["text/event-stream"] = {
                            "schema": schema
                        }
            operation["responses"] = resp

            paths.setdefault(path, {})[http_method] = operation

        # Recurse into nested resources
        extract_methods(resource.get("resources"), version_prefix, paths)

    return paths


def convert(discovery):
    """Convert a Google Discovery document to OpenAPI 3.0.3."""
    version = discovery.get("version", "v1")
    root_url = discovery.get("rootUrl", "").rstrip("/")

    openapi = {
        "openapi": "3.0.3",
        "info": {
            "title": discovery.get("title", ""),
            "description": discovery.get("description", ""),
            "version": version,
        },
        "servers": [{"url": f"{root_url}/{version}"}],
        "paths": extract_methods(
            discovery.get("resources"), f"{version}/"
        ),
        "components": {
            "schemas": {
                name: convert_schema(schema)
                for name, schema in (discovery.get("schemas") or {}).items()
            }
        },
    }

    return openapi


def main():
    if len(sys.argv) < 3:
        print(f"Usage: {sys.argv[0]} <input_discovery.json> <output_openapi.json>")
        sys.exit(1)

    with open(sys.argv[1]) as f:
        discovery = json.load(f)

    openapi = convert(discovery)

    with open(sys.argv[2], "w") as f:
        json.dump(openapi, f, indent=2)

    print(
        f"Converted {len(openapi['paths'])} paths, "
        f"{len(openapi['components']['schemas'])} schemas"
    )


if __name__ == "__main__":
    main()
