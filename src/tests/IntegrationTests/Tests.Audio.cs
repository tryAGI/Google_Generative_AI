namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Speak_SimpleText()
    {
        using var client = GetAuthenticatedClient();

        var result = await client.SpeakAsync(
            text: "Hello, this is a test of text to speech.",
            voiceName: "Puck");

        result.HasAudio.Should().BeTrue();
        result.AudioData.Should().NotBeNullOrEmpty();
        result.MimeType.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Speak_DifferentVoice()
    {
        using var client = GetAuthenticatedClient();

        var result = await client.SpeakAsync(
            text: "Testing with a different voice.",
            voiceName: "Kore");

        result.HasAudio.Should().BeTrue();
        result.AudioData.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Transcribe_GeneratedAudio()
    {
        using var client = GetAuthenticatedClient();

        // First generate audio to transcribe
        var audio = await client.SpeakAsync(
            text: "The quick brown fox jumps over the lazy dog.");

        audio.HasAudio.Should().BeTrue("need audio to transcribe");

        var transcription = await client.TranscribeAsync(
            audioData: audio.AudioData!,
            mimeType: audio.MimeType ?? "audio/wav");

        transcription.Should().NotBeNullOrWhiteSpace();
    }
}
