#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: Google Discovery API https://generativelanguage.googleapis.com/\$discovery/rest?version=v1beta (converted to OpenAPI via Python)
install_autosdk_cli
fetch_spec --fail --silent --show-error -L -o discovery.json 'https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta'
python3 convert_discovery.py discovery.json openapi.next.json
rm discovery.json

# Post-process the OpenAPI spec:
# 1. Ensure VIDEO modality is present in responseModalities enum
# 2. Remove deprecated legacy PaLM endpoints
# 3. Prune orphaned schemas no longer referenced by any endpoint
python3 postprocess_discovery.py openapi.next.json

# The Discovery API can reorder equivalent JSON objects between requests. Avoid
# regenerating public constructor parameter order when the contract is unchanged.
if [[ -f openapi.json ]] && python3 - openapi.json openapi.next.json <<'PY'
import json
import sys

with open(sys.argv[1], 'r') as current_file:
    current = json.load(current_file)
with open(sys.argv[2], 'r') as next_file:
    next_spec = json.load(next_file)

sys.exit(0 if current == next_spec else 1)
PY
then
  rm openapi.next.json
  python3 emit_sse_hook.py
  ./generate_nextgen.sh
  echo 'OpenAPI contract is semantically unchanged; skipping regeneration.'
  exit 0
fi

mv openapi.next.json openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace Google.Gemini \
  --clientClassName GeminiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://generativelanguage.googleapis.com/v1beta \
  --security-scheme ApiKey:Query:key
python3 emit_sse_hook.py
./generate_nextgen.sh
