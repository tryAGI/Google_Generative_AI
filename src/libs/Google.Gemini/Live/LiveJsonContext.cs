#nullable enable

namespace Google.Gemini;

using System.Text.Json.Serialization;

/// <summary>
/// Source-generated JSON serialization context for Live API types.
/// SDK-generated types (Content, Part, Blob, etc.) are handled by
/// <see cref="SourceGenerationContext"/> and should NOT be listed here.
/// </summary>
[JsonSerializable(typeof(LiveClientMessage))]
[JsonSerializable(typeof(LiveServerMessage))]
[JsonSerializable(typeof(LiveSetupConfig))]
[JsonSerializable(typeof(LiveRealtimeInput))]
[JsonSerializable(typeof(LiveClientContent))]
[JsonSerializable(typeof(LiveToolResponse))]
[JsonSerializable(typeof(LiveServerContent))]
[JsonSerializable(typeof(LiveToolCall))]
[JsonSerializable(typeof(LiveToolCallCancellation))]
[JsonSerializable(typeof(LiveGoAway))]
[JsonSerializable(typeof(LiveSessionResumptionUpdate))]
[JsonSerializable(typeof(LiveSetupComplete))]
[JsonSerializable(typeof(LiveTranscription))]
[JsonSerializable(typeof(LiveActivityStart))]
[JsonSerializable(typeof(LiveActivityEnd))]
[JsonSerializable(typeof(LiveSessionResumptionConfig))]
[JsonSerializable(typeof(LiveContextWindowCompression))]
[JsonSerializable(typeof(LiveSlidingWindow))]
[JsonSerializable(typeof(LiveInputAudioTranscription))]
[JsonSerializable(typeof(LiveOutputAudioTranscription))]
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
internal sealed partial class LiveJsonContext : JsonSerializerContext;
