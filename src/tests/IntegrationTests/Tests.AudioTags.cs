using System.Reflection;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void GeminiAudioTags_AllConstants_FollowBracketedSyntax()
    {
        var constants = typeof(GeminiAudioTags)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(f => f.IsLiteral && f.FieldType == typeof(string))
            .Select(f => (f.Name, Value: (string)f.GetRawConstantValue()!))
            .ToList();

        constants.Should().NotBeEmpty("GeminiAudioTags must expose at least one constant");

        foreach (var (name, value) in constants)
        {
            value.Should().StartWith("[", $"{name} must use bracketed audio-tag syntax");
            value.Should().EndWith("]", $"{name} must use bracketed audio-tag syntax");
            value.Length.Should().BeGreaterThan(2, $"{name} must contain a non-empty tag body");
            value.Trim().Should().Be(value, $"{name} must not contain leading/trailing whitespace");
        }
    }

    [TestMethod]
    public void GeminiVoices_AllConstants_NonEmptyAndDistinct()
    {
        var constants = typeof(GeminiVoices)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(f => f.IsLiteral && f.FieldType == typeof(string))
            .Select(f => (f.Name, Value: (string)f.GetRawConstantValue()!))
            .ToList();

        constants.Should().HaveCountGreaterThan(20, "Gemini ships 30 prebuilt voices");

        foreach (var (name, value) in constants)
        {
            value.Should().NotBeNullOrWhiteSpace($"{name} must have a non-empty voice id");
            value.Should().NotContain(" ", $"{name} voice id must not contain whitespace");
        }

        var values = constants.ConvertAll(c => c.Value);
        values.Should().OnlyHaveUniqueItems("voice ids must be distinct");
    }

    [TestMethod]
    public void GeminiVoices_All_MatchesConstantCount()
    {
        var fieldCount = typeof(GeminiVoices)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Count(f => f.IsLiteral && f.FieldType == typeof(string));

        GeminiVoices.All.Should().HaveCount(fieldCount, "GeminiVoices.All must enumerate every constant");
        GeminiVoices.All.Should().OnlyHaveUniqueItems();
    }
}
