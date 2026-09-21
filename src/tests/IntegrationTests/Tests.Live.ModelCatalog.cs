namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Live_ModelCatalog_SelectsApiVersionPerProtocol()
    {
        GeminiLiveModelCatalog.GetApiVersion(GeminiLiveModelCatalog.Gemini38Live)
            .Should().Be("v1beta");
        GeminiLiveModelCatalog.GetApiVersion($"models/{GeminiLiveModelCatalog.Gemini38LiveExtendedThinking}")
            .Should().Be("v1alpha");
        GeminiLiveModelCatalog.GetApiVersion(GeminiLiveModelCatalog.Gemini31FlashLive)
            .Should().Be("v1beta");
    }

    [TestMethod]
    public void Live_ModelCatalog_ConfiguresChartThinkingVariants()
    {
        var minimal = CreateThinkingConfig(GeminiLiveModelCatalog.Gemini31FlashLive, "minimal");
        var high = CreateThinkingConfig(GeminiLiveModelCatalog.Gemini31FlashLive, "high");
        var extendedHigh = CreateThinkingConfig(GeminiLiveModelCatalog.Gemini38LiveExtendedThinking, "high");

        minimal.GenerationConfig!.ThinkingConfig!.ThinkingLevel.Should().Be(ThinkingConfigThinkingLevel.Minimal);
        high.GenerationConfig!.ThinkingConfig!.ThinkingLevel.Should().Be(ThinkingConfigThinkingLevel.High);
        extendedHigh.GenerationConfig!.ThinkingConfig!.ThinkingLevel.Should().Be(ThinkingConfigThinkingLevel.High);
    }

    [TestMethod]
    public void Live_ExtendedThinking_UsesNonBlockingFunctions()
    {
        var declaration = new FunctionDeclaration { Name = "lookup" };
        var config = CreateThinkingConfig(GeminiLiveModelCatalog.Gemini38LiveExtendedThinking, "high");
        config.Tools = [new Tool { FunctionDeclarations = [declaration] }];

        GeminiLiveModelCatalog.PrepareForConnection(config);

        declaration.Behavior.Should().Be(FunctionDeclarationBehavior.NonBlocking);
    }

    [TestMethod]
    public void Live_InteractionStatus_IdleIsTerminal()
    {
        new LiveServerMessage { InteractionStatus = "IN_PROGRESS" }.IsInteractionIdle.Should().BeFalse();
        new LiveServerMessage { InteractionStatus = "IDLE" }.IsInteractionIdle.Should().BeTrue();
    }

    [TestMethod]
    public void Live_Gemini38WithoutThinking_RejectsThinkingConfig()
    {
        var config = new LiveSetupConfig { Model = GeminiLiveModelCatalog.Gemini38Live };

        var action = () => GeminiLiveModelCatalog.ApplyThinkingEffort(config, "high");

        action.Should().Throw<ArgumentException>();
    }

    private static LiveSetupConfig CreateThinkingConfig(string model, string effort)
    {
        var config = new LiveSetupConfig { Model = model };
        GeminiLiveModelCatalog.ApplyThinkingEffort(config, effort);
        return config;
    }
}
