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

    [TestMethod]
    public void AudioResult_WriteWavTo_EmitsRiffWaveHeader()
    {
        var pcm = new byte[] { 0x01, 0x00, 0x02, 0x00, 0x03, 0x00, 0x04, 0x00 };
        var result = new AudioResult
        {
            AudioData = pcm,
            MimeType = "audio/L16;codec=pcm;rate=16000",
        };

        using var ms = new MemoryStream();
        result.WriteWavTo(ms);

        var bytes = ms.ToArray();
        bytes.Length.Should().Be(44 + pcm.Length, "WAV header is 44 bytes for PCM");

        // RIFF / WAVE / fmt  / data chunk IDs in the standard offsets.
        System.Text.Encoding.ASCII.GetString(bytes, 0, 4).Should().Be("RIFF");
        System.Text.Encoding.ASCII.GetString(bytes, 8, 4).Should().Be("WAVE");
        System.Text.Encoding.ASCII.GetString(bytes, 12, 4).Should().Be("fmt ");
        System.Text.Encoding.ASCII.GetString(bytes, 36, 4).Should().Be("data");

        // Sample rate at offset 24 (little-endian uint32) should match parsed rate.
        BitConverter.ToInt32(bytes, 24).Should().Be(16000);

        // Body should be the PCM payload verbatim.
        bytes.AsSpan(44).ToArray().Should().BeEquivalentTo(pcm);
    }

    [TestMethod]
    public void AudioResult_WriteWavTo_UsesExplicitSampleRateOverParse()
    {
        var result = new AudioResult
        {
            AudioData = new byte[] { 0, 0 },
            MimeType = "audio/L16;codec=pcm;rate=24000",
        };

        using var ms = new MemoryStream();
        result.WriteWavTo(ms, sampleRate: 48000);

        BitConverter.ToInt32(ms.ToArray(), 24).Should().Be(48000);
    }

    [TestMethod]
    public void AudioResult_WriteWavTo_ThrowsWhenNoAudio()
    {
        var result = new AudioResult { AudioData = null };
        using var ms = new MemoryStream();

        var act = () => result.WriteWavTo(ms);
        act.Should().Throw<InvalidOperationException>();
    }

    // Regression: new MemoryStream(byte[]) is non-publicly-visible, so the
    // earlier GuessMimeType implementation that called GetBuffer() threw
    // UnauthorizedAccessException. The fix switched to ToArray().
    [TestMethod]
    public async Task GeminiClient_ReadAudioAsync_HandlesNonPubliclyVisibleMemoryStream()
    {
        // 4-byte RIFF prefix is enough for sniffing; pad to look like a WAV.
        byte[] wavBytes = "RIFF\0\0\0\0WAVE"u8.ToArray();
        using var stream = new MemoryStream(wavBytes);

        var (data, mimeType) = await GeminiClient.ReadAudioAsync(stream, CancellationToken.None);

        data.Should().BeEquivalentTo(wavBytes);
        mimeType.Should().Be("audio/wav");
    }

    [TestMethod]
    public async Task GeminiClient_ReadAudioAsync_ReadsArbitraryStream()
    {
        byte[] oggBytes = "OggS\0\0\0\0extra"u8.ToArray();
        using var inner = new MemoryStream(oggBytes);
        using var wrapper = new BufferedStream(inner);

        var (data, mimeType) = await GeminiClient.ReadAudioAsync(wrapper, CancellationToken.None);

        data.Should().BeEquivalentTo(oggBytes);
        mimeType.Should().Be("audio/ogg");
    }

    [TestMethod]
    [DataRow(new byte[] { (byte)'R', (byte)'I', (byte)'F', (byte)'F' }, "audio/wav")]
    [DataRow(new byte[] { (byte)'O', (byte)'g', (byte)'g', (byte)'S' }, "audio/ogg")]
    [DataRow(new byte[] { (byte)'f', (byte)'L', (byte)'a', (byte)'C' }, "audio/flac")]
    [DataRow(new byte[] { (byte)'I', (byte)'D', (byte)'3', 0x03 }, "audio/mp3")]
    [DataRow(new byte[] { 0xFF, 0xFB, 0x00, 0x00 }, "audio/mp3")]
    [DataRow(new byte[] { 0x00, 0x00, 0x00 }, "audio/wav")] // too short → default
    [DataRow(new byte[] { 0x00, 0x01, 0x02, 0x03 }, "audio/wav")] // unknown → default
    public void GeminiClient_GuessMimeType_SniffsMagicBytes(byte[] header, string expected)
    {
        GeminiClient.GuessMimeType(header).Should().Be(expected);
    }
}
