#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: Google Discovery API https://generativelanguage.googleapis.com/\$discovery/rest?version=v1beta (converted to OpenAPI via Python)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o discovery.json 'https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta'
python3 convert_discovery.py discovery.json openapi.json
rm discovery.json

# Post-process the OpenAPI spec:
# 1. Ensure VIDEO modality is present in responseModalities enum
# 2. Remove deprecated legacy PaLM endpoints
# 3. Prune orphaned schemas no longer referenced by any endpoint
python3 -c "
import json, re

with open('openapi.json', 'r') as f:
    spec = json.load(f)

changed = False

# --- Inject VIDEO modality ---
gen_config = spec.get('components', {}).get('schemas', {}).get('GenerationConfig', {}).get('properties', {}).get('responseModalities', {})
items = gen_config.get('items', {})
enums = items.get('enum', [])
descs = items.get('x-enum-descriptions', [])

if enums and 'VIDEO' not in enums:
    enums.append('VIDEO')
    descs.append('Indicates the model should return video.')
    changed = True
    print('Injected VIDEO modality into responseModalities enum')
else:
    print('VIDEO modality already present or enum not found')

# --- Remove legacy PaLM endpoints ---
legacy_suffixes = [
    ':generateText', ':generateMessage', ':embedText', ':batchEmbedText',
    ':countTextTokens', ':countMessageTokens', ':generateAnswer',
    ':predict', ':predictLongRunning',
]
paths_to_remove = [
    path for path in spec.get('paths', {})
    if any(path.endswith(suffix) for suffix in legacy_suffixes)
]
for path in paths_to_remove:
    del spec['paths'][path]
    changed = True
if paths_to_remove:
    print(f'Removed {len(paths_to_remove)} legacy PaLM endpoints')
else:
    print('No legacy PaLM endpoints found')

# --- Prune orphaned schemas ---
def find_refs(name, schemas, visited):
    if name in visited or name not in schemas:
        return
    visited.add(name)
    for ref in re.findall(r'#/components/schemas/(\w+)', json.dumps(schemas[name])):
        find_refs(ref, schemas, visited)

all_schemas = spec.get('components', {}).get('schemas', {})
used = set()
for ref in re.findall(r'#/components/schemas/(\w+)', json.dumps(spec.get('paths', {}))):
    find_refs(ref, all_schemas, used)
orphaned = sorted(set(all_schemas.keys()) - used)
for name in orphaned:
    del all_schemas[name]
    changed = True
if orphaned:
    print(f'Pruned {len(orphaned)} orphaned schemas: {orphaned}')
else:
    print('No orphaned schemas found')

if changed:
    with open('openapi.json', 'w') as f:
        json.dump(spec, f, indent=2)
        f.write('\n')
"
autosdk generate openapi.json \
  --namespace Google.Gemini \
  --clientClassName GeminiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://generativelanguage.googleapis.com/v1beta \
  --security-scheme ApiKey:Query:key
