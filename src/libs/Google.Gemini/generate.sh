dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# NOTE: The original curated spec URL is no longer available (repo was reorganized).
# The spec source moved to: https://github.com/davidmigloz/ai_clients_dart/tree/main/packages/googleai_dart/specs
# Using the existing openapi.yaml committed in this repo instead.
# curl -o openapi.yaml https://raw.githubusercontent.com/davidmigloz/langchain_dart/refs/heads/main/packages/googleai_dart/oas/googleai_openapi_curated.yaml
autosdk generate openapi.yaml \
  --namespace Google.Gemini \
  --clientClassName GeminiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://generativelanguage.googleapis.com/v1beta \
  --security-scheme ApiKey:Query:key
