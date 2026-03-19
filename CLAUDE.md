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
3. `src/libs/Google.Gemini/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Google.Gemini/` | Main SDK library (`GeminiClient`) |
| `src/libs/Google.Gemini/Live/` | Hand-written Live API (WebSocket) types and session |
| `src/tests/IntegrationTests/` | Integration tests against real Google Gemini API |
| `samples/LiveVoiceAssistant/` | Console app sample for Live API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions
- **NuGet Package ID:** `Google_Gemini` (underscores due to NuGet naming restrictions)

### Key Conventions

- The client class is named `GeminiClient`
- The namespace is `Google.Gemini`
- Note the NuGet package ID uses underscores (`Google_Gemini`) while the namespace uses dots (`Google.Gemini`)

### Hand-Written Extensions

While the HTTP API client is purely auto-generated, the following hand-written files extend the SDK:

**Live API (WebSocket real-time streaming):**
- `src/libs/Google.Gemini/Live/` — Message types for the bidirectional WebSocket protocol
  - `LiveSetupConfig.cs` — Session setup configuration
  - `LiveClientMessage.cs` — Client → server message union
  - `LiveServerMessage.cs` — Server → client message union + JSON parsing
  - `LiveServerContent.cs` — Model turn, transcriptions, interruption
  - `LiveToolCall.cs` — Tool call + cancellation wrappers
  - `LiveRealtimeInput.cs` — Audio/text/video input chunks
  - `LiveGoAway.cs` — Graceful disconnect notification
  - `LiveSessionResumption.cs` — Session resumption handle types
  - `LiveJsonContext.cs` — Source-generated JSON context for AOT (reserved)
  - `GeminiLiveSession.cs` — WebSocket session class (`IAsyncDisposable`)
  - `ResilientLiveSession.cs` — Auto-reconnect wrapper that handles GoAway messages
- `src/libs/Google.Gemini/Extensions/GeminiClientExtensions.Live.cs` — `ConnectLiveAsync` and `ConnectResilientLiveAsync` factory methods

**MEAI integration:**
- `src/libs/Google.Gemini/Extensions/` — `IChatClient` and `IEmbeddingGenerator` implementations

**Important:** The Live API sends JSON as **Binary** WebSocket frames (not Text). Only `native-audio` models (e.g., `models/gemini-2.5-flash-native-audio-latest`) support `bidiGenerateContent` and require `AUDIO` response modality.

### Samples

- `samples/LiveVoiceAssistant/` — Console app demonstrating the Live API (text-in/audio-out with transcription)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
