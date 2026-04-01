namespace Google.Gemini.IntegrationTests;

using System.Text.Json;
using System.Text.Json.Serialization;

public partial class Tests
{
    [TestMethod]
    public void Live_ParametersJsonSchema_SerializesRawJsonSchema()
    {
        var weatherSchema = JsonDocument.Parse("""
            {
              "type": "object",
              "additionalProperties": false,
              "propertyOrdering": ["location", "units", "preferences"],
              "properties": {
                "location": {
                  "type": "string",
                  "description": "The city name"
                },
                "units": {
                  "type": "string",
                  "enum": ["celsius", "fahrenheit"]
                },
                "preferences": {
                  "type": "object",
                  "additionalProperties": false,
                  "propertyOrdering": ["includeHumidity"],
                  "properties": {
                    "includeHumidity": {
                      "type": "boolean"
                    }
                  }
                }
              },
              "required": ["location"]
            }
            """).RootElement.Clone();

        var config = new LiveSetupConfig
        {
            Model = "models/gemini-3.1-flash-live-preview",
            Tools =
            [
                new Tool
                {
                    FunctionDeclarations =
                    [
                        new FunctionDeclaration
                        {
                            Name = "get_weather",
                            Description = "Get the current weather for a location",
                            ParametersJsonSchema = weatherSchema,
                        },
                    ],
                },
            ],
        };

        var jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        foreach (var converter in SourceGenerationContext.Default.Options.Converters)
        {
            jsonOptions.Converters.Add(converter);
        }

        var payload = JsonSerializer.Serialize(new LiveClientMessage { Setup = config }, jsonOptions);

        using var document = JsonDocument.Parse(payload);
        var functionDeclaration = document.RootElement
            .GetProperty("setup")
            .GetProperty("tools")[0]
            .GetProperty("functionDeclarations")[0];

        functionDeclaration.TryGetProperty("parameters", out _).Should().BeFalse();

        var serializedSchema = functionDeclaration.GetProperty("parametersJsonSchema");
        serializedSchema.GetProperty("additionalProperties").GetBoolean().Should().BeFalse();
        serializedSchema
            .GetProperty("propertyOrdering")
            .EnumerateArray()
            .Select(static property => property.GetString())
            .Should()
            .Equal(["location", "units", "preferences"]);

        var preferences = serializedSchema
            .GetProperty("properties")
            .GetProperty("preferences");

        preferences.GetProperty("additionalProperties").GetBoolean().Should().BeFalse();
        preferences
            .GetProperty("properties")
            .GetProperty("includeHumidity")
            .GetProperty("type")
            .GetString()
            .Should()
            .Be("boolean");
    }
}
