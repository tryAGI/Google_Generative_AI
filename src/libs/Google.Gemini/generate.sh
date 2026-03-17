set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o discovery.json 'https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta'
python3 convert_discovery.py discovery.json openapi.json
rm discovery.json
autosdk generate openapi.json \
  --namespace Google.Gemini \
  --clientClassName GeminiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://generativelanguage.googleapis.com/v1beta \
  --security-scheme ApiKey:Query:key
