#!/usr/bin/env python3
"""Adapt Google's official Interactions OpenAPI document for the Gemini SDK."""

import json
import sys


def normalize(source):
    # Google documents the API version as a path parameter. This package targets
    # v1beta, like the existing Gemini client, so callers need no version argument.
    source["paths"] = {
        path.replace("{api_version}", "v1beta"): item
        for path, item in source["paths"].items()
    }

    for item in source["paths"].values():
        # AutoSDK reads operation parameters. The path-level refs otherwise cause
        # duplicate parameters, and Speakeasy's renamed path arguments can produce
        # an unresolved identifier in generated request URLs.
        item.pop("parameters", None)
        for operation in item.values():
            for parameter in operation.get("parameters", []):
                if parameter.get("in") == "path":
                    parameter.pop("x-speakeasy-name-override", None)

    return source


if __name__ == "__main__":
    with open(sys.argv[1], encoding="utf-8") as input_file:
        document = json.load(input_file)
    with open(sys.argv[2], "w", encoding="utf-8") as output_file:
        json.dump(normalize(document), output_file, indent=2, ensure_ascii=False)
        output_file.write("\n")
