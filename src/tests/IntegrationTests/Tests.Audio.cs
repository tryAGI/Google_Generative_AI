namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("audio/L16;codec=pcm;rate=24000", 24000)]
    [DataRow("audio/L16; codec=pcm; rate=16000", 16000)]
    [DataRow("audio/L16;codec=pcm;rate=44100", 44100)]
    [DataRow("audio/L16;rate=8000;codec=pcm", 8000)]
    [DataRow("AUDIO/L16;CODEC=PCM;RATE=22050", 22050)]
    public void AudioResult_ParseSampleRateHz_ExtractsRate(string mimeType, int expected)
    {
        AudioResult.ParseSampleRateHz(mimeType).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("audio/wav")]
    [DataRow("audio/mp3")]
    [DataRow("audio/L16;codec=pcm")]
    [DataRow("")]
    [DataRow(null)]
    public void AudioResult_ParseSampleRateHz_ReturnsNullWhenAbsent(string? mimeType)
    {
        AudioResult.ParseSampleRateHz(mimeType).Should().BeNull();
    }

    [TestMethod]
    public void AudioResult_ParseSampleRateHz_ReturnsNullWhenRateIsNotNumeric()
    {
        AudioResult.ParseSampleRateHz("audio/L16;codec=pcm;rate=abc").Should().BeNull();
    }

    [TestMethod]
    public void AudioResult_SampleRateHz_MirrorsParseResult()
    {
        var result = new AudioResult { MimeType = "audio/L16;codec=pcm;rate=24000" };
        result.SampleRateHz.Should().Be(24000);

        new AudioResult { MimeType = null }.SampleRateHz.Should().BeNull();
        new AudioResult { MimeType = "audio/wav" }.SampleRateHz.Should().BeNull();
    }
}
