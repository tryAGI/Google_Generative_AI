#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")"

source_file=$(mktemp)
next_file=$(mktemp)
output_dir=NextGen/Generated.next
trap 'rm -f "$source_file" "$next_file"; rm -rf "$output_dir"' EXIT

curl --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  https://ai.google.dev/static/api/interactions.openapi.json \
  -o "$source_file"
python3 normalize_nextgen_spec.py "$source_file" "$next_file"

if [[ -f nextgen.openapi.json && -d NextGen/Generated ]] && \
  python3 - nextgen.openapi.json "$next_file" <<'PY'
import json
import sys
with open(sys.argv[1], encoding="utf-8") as previous_file:
    previous = json.load(previous_file)
with open(sys.argv[2], encoding="utf-8") as next_file:
    current = json.load(next_file)
sys.exit(0 if previous == current else 1)
PY
then
  echo 'NextGen OpenAPI contract is semantically unchanged; skipping regeneration.'
  exit 0
fi

rm -rf "$output_dir"
autosdk generate "$next_file" \
  --namespace Google.Gemini.NextGen \
  --clientClassName GeminiNextGenClient \
  --targetFramework net10.0 \
  --output "$output_dir" \
  --base-url https://generativelanguage.googleapis.com \
  --security-scheme ApiKey:Header:x-goog-api-key

# The System.Text.Json generator uses unqualified hint names, so two generated
# contexts named SourceGenerationContext cannot compile in one assembly even
# when their C# namespaces differ. Rename only this generated context's exact
# identifier before including both API clients in the same NuGet package.
python3 - "$output_dir" <<'PY'
from pathlib import Path
import re
import sys

for path in Path(sys.argv[1]).glob("*.cs"):
    source = path.read_text(encoding="utf-8")
    updated = re.sub(r"\bSourceGenerationContext\b", "NextGenSourceGenerationContext", source)
    if updated != source:
        path.write_text(updated, encoding="utf-8")
PY

mv "$next_file" nextgen.openapi.json
if [[ -d NextGen/Generated ]]; then
  rm -rf NextGen/Generated
fi
mv "$output_dir" NextGen/Generated
