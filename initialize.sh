dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Google.Gemini \
  GeminiClient \
  https://raw.githubusercontent.com/davidmigloz/langchain_dart/refs/heads/main/packages/googleai_dart/oas/googleai_openapi_curated.yaml \
  tryAGI \
  --output .
