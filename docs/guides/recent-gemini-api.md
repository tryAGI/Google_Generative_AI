# Recent Gemini API releases

The package contains two clients because Google currently publishes two API
contracts. `GeminiClient` covers the GenerateContent, Files, and Live APIs from
the [Discovery document](https://generativelanguage.googleapis.com/$discovery/rest?version=v1beta).
`GeminiNextGenClient` covers the [official Interactions OpenAPI
document](https://ai.google.dev/static/api/interactions.openapi.json), including
Voices, Interactions, agents, triggers, webhooks, credentials, and environments.
Both clients are generated into this package and accept the same API key.

| Release | SDK surface |
| --- | --- |
| Gemini 3.8 Flash and Flash-Lite TTS | `SpeakAsync` defaults to Flash-Lite; `SpeakAdvancedAsync` selects either model, style, voice ID or key, and audio format. The generated `SpeechConfig` and `SpeechMetadata` types cover multi-speaker turns. |
| Voice design, replication, and Extended Voice Library | `GeminiNextGenClient.Voices` supports create, list with filters and pagination, get, and delete. `CreateVoiceRequest.Store` controls persistent and stateless replication modes. |
| Gemini 3.8 Live and Live Extended Thinking | `GeminiLiveModelCatalog` and `ConnectLiveAsync` select the models and validate thinking configuration. |
| Gemini 3.8 Flash | Pass `gemini-3.8-flash` to GenerateContent or use `NextGen.Model.Gemini38Flash` with Interactions. |
| Lyria 3.5 and Gemini Omni Flash | Use `GeminiNextGenClient.Interactions`. The generated Interactions models cover audio and video inputs and output controls. Model IDs remain open strings, so newly released IDs work without a package update. |
| Gemini 3.5 Transcribe and Transcribe Live | Use `Transcribe35FileAsync` or `Transcribe35Async` for unary audio and `gemini-3.5-transcribe-live` with `ConnectLiveAsync` for live audio. Generated `AudioTranscriptionConfig` exposes language, vocabulary, timestamp, diarization, and mode controls. |
| Antigravity Agent and platform events | `GeminiNextGenClient.Agents`, `.Interactions`, `.Triggers`, `.Webhooks`, `.Credentials`, and `.Environments` expose the published typed operations. |

See Google's [release notes](https://ai.google.dev/gemini-api/docs/changelog)
for model availability, restrictions, and migration notes. Model releases that
only add an ID can be used immediately because model parameters are not closed
enums.

## Example: design and use a voice

```csharp
using Google.Gemini;
using Google.Gemini.NextGen;

using var voicesClient = new GeminiNextGenClient(apiKey);
var voice = await voicesClient.Voices.CreateAsync(new CreateVoiceRequest
{
    Store = true,
    Voice = new Voice
    {
        Type = VoiceType.Prompted,
        Prompted = new PromptedVoice { Input = "A gentle, thoughtful narrator" },
    },
});

using var ttsClient = new GeminiClient(apiKey);
var audio = await ttsClient.SpeakAdvancedAsync(
    "Welcome to the story.", voiceName: voice.Id!,
    modelId: "gemini-3.8-flash-tts", style: "warm and clear");
audio.WriteWavFile("narration.wav");
```

Voice replication requires a reference recording and a separate consent
recording in `ReplicatedVoice.SourceAudio` and `ConsentAudio`. The API validates
consent during creation; the SDK forwards those fields without synthesizing
consent or storing recordings locally.

## Regeneration

Run `src/libs/Google.Gemini/generate.sh` to refresh both contracts. The
NextGen generator normalizes Google's `{api_version}` path parameter to
`v1beta` and preserves a pinned copy in `nextgen.openapi.json`. It also gives
the second JSON source generation context a distinct name so both clients
compile in one assembly. Do not edit either `Generated/` tree by hand.
