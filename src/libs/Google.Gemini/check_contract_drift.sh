#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")"
scratch=$(mktemp -d)
trap 'rm -rf "$scratch"' EXIT

fetch_spec() {
  curl --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300 "$@"
}

fetch_spec 'https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta' \
  -o "$scratch/discovery.json"
python3 convert_discovery.py "$scratch/discovery.json" "$scratch/discovery.openapi.json"
python3 postprocess_discovery.py "$scratch/discovery.openapi.json"

fetch_spec 'https://ai.google.dev/static/api/interactions.openapi.json' \
  -o "$scratch/nextgen.json"
python3 normalize_nextgen_spec.py "$scratch/nextgen.json" "$scratch/nextgen.openapi.json"

python3 compare_contracts.py openapi.json "$scratch/discovery.openapi.json" \
  nextgen.openapi.json "$scratch/nextgen.openapi.json"
