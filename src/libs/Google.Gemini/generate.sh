set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o discovery.json 'https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta'
python3 convert_discovery.py discovery.json openapi.json
rm discovery.json

# Post-process the OpenAPI spec:
# 1. Ensure VIDEO modality is present in responseModalities enum
# 2. Remove deprecated legacy PaLM endpoints (generateText, generateMessage,
#    embedText, batchEmbedText, countTextTokens, countMessageTokens,
#    generateAnswer, predict, predictLongRunning)
python3 -c "
import json, sys
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
    print(f'Removed {len(paths_to_remove)} legacy PaLM endpoints: {paths_to_remove}')
else:
    print('No legacy PaLM endpoints found')

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
