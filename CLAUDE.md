# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Google Gemini](https://ai.google.dev/) generative AI API, auto-generated from a curated Google AI OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as NuGet package `Google_Gemini`.

## Build Commands

```bash
# Build the solution
dotnet build Google.Gemini.slnx

# Build for release (also produces NuGet package)
dotnet build Google.Gemini.slnx -c Release

# Run integration tests (requires GOOGLE_GEMINI_API_KEY or API_KEY env var)
dotnet test src/tests/IntegrationTests/Google.Gemini.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Google.Gemini && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Google.Gemini/Generated/`.

1. `src/libs/Google.Gemini/openapi.yaml` -- the Google Gemini OpenAPI spec (fetched from a curated spec in the `langchain_dart` repo)
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/Google.Gemini/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Google.Gemini/` | Main SDK library (`GeminiClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Google Gemini API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions
- **NuGet Package ID:** `Google_Gemini` (underscores due to NuGet naming restrictions)

### Key Conventions

- No hand-written extension files -- the SDK is purely generated code
- The client class is named `GeminiClient`
- The namespace is `Google.Gemini`
- Note the NuGet package ID uses underscores (`Google_Gemini`) while the namespace uses dots (`Google.Gemini`)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
