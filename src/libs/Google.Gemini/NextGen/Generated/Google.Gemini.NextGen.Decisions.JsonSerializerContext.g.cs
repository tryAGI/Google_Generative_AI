
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Annotation), TypeInfoPropertyName = "Annotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PlaceCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpeechAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WordInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Answer), TypeInfoPropertyName = "Answer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ChoiceAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.NoulAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ScoreAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>), TypeInfoPropertyName = "OneOfAudioMediaProcessingAudioContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioMediaProcessing), TypeInfoPropertyName = "AudioMediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContentProcessing), TypeInfoPropertyName = "AudioContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContentMimeType), TypeInfoPropertyName = "AudioContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioStaticMediaProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ChoiceQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>), TypeInfoPropertyName = "OneOfDecisionInstructionContentIListDecisionInstructionContentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInstructionContent), TypeInfoPropertyName = "DecisionInstructionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseModality), TypeInfoPropertyName = "ResponseModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateDecisionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>), TypeInfoPropertyName = "OneOfDecisionInputContentIListDecisionInputContentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInputContent), TypeInfoPropertyName = "DecisionInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Question), TypeInfoPropertyName = "Question2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateDecisionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Answer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PromptFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.NoulCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType), TypeInfoPropertyName = "DecisionInstructionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaResolution), TypeInfoPropertyName = "MediaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DocumentMediaProcessing?, global::Google.Gemini.NextGen.DocumentContentProcessing?>), TypeInfoPropertyName = "OneOfDocumentMediaProcessingDocumentContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentMediaProcessing), TypeInfoPropertyName = "DocumentMediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContentProcessing), TypeInfoPropertyName = "DocumentContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContentMimeType), TypeInfoPropertyName = "DocumentContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentStaticMediaProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PageProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ReviewSnippet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCountType), TypeInfoPropertyName = "GroundingToolCountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageContentMimeType), TypeInfoPropertyName = "ImageContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaProcessing), TypeInfoPropertyName = "MediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StaticMediaProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ModalityTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.NoulQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer), TypeInfoPropertyName = "PageProcessingOptionsContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason), TypeInfoPropertyName = "PromptFeedbackBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ScoreQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer), TypeInfoPropertyName = "SpreadsheetProcessingOptionsContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer), TypeInfoPropertyName = "StaticMediaProcessingContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>), TypeInfoPropertyName = "OneOfMediaProcessingVideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentProcessing), TypeInfoPropertyName = "VideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentMimeType), TypeInfoPropertyName = "VideoContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Annotation?), TypeInfoPropertyName = "NullableAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Answer?), TypeInfoPropertyName = "NullableAnswer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>?), TypeInfoPropertyName = "NullableOneOfAudioMediaProcessingAudioContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioMediaProcessing?), TypeInfoPropertyName = "NullableAudioMediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContentProcessing?), TypeInfoPropertyName = "NullableAudioContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContentMimeType?), TypeInfoPropertyName = "NullableAudioContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>?), TypeInfoPropertyName = "NullableOneOfDecisionInstructionContentIListDecisionInstructionContentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInstructionContent?), TypeInfoPropertyName = "NullableDecisionInstructionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseModality?), TypeInfoPropertyName = "NullableResponseModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>?), TypeInfoPropertyName = "NullableOneOfDecisionInputContentIListDecisionInputContentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInputContent?), TypeInfoPropertyName = "NullableDecisionInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Question?), TypeInfoPropertyName = "NullableQuestion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType?), TypeInfoPropertyName = "NullableDecisionInstructionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaResolution?), TypeInfoPropertyName = "NullableMediaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DocumentMediaProcessing?, global::Google.Gemini.NextGen.DocumentContentProcessing?>?), TypeInfoPropertyName = "NullableOneOfDocumentMediaProcessingDocumentContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentMediaProcessing?), TypeInfoPropertyName = "NullableDocumentMediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContentProcessing?), TypeInfoPropertyName = "NullableDocumentContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContentMimeType?), TypeInfoPropertyName = "NullableDocumentContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCountType?), TypeInfoPropertyName = "NullableGroundingToolCountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageContentMimeType?), TypeInfoPropertyName = "NullableImageContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaProcessing?), TypeInfoPropertyName = "NullableMediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer?), TypeInfoPropertyName = "NullablePageProcessingOptionsContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason?), TypeInfoPropertyName = "NullablePromptFeedbackBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer?), TypeInfoPropertyName = "NullableSpreadsheetProcessingOptionsContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer?), TypeInfoPropertyName = "NullableStaticMediaProcessingContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>?), TypeInfoPropertyName = "NullableOneOfMediaProcessingVideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentProcessing?), TypeInfoPropertyName = "NullableVideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentMimeType?), TypeInfoPropertyName = "NullableVideoContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInstructionContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInputContent>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>))]
    internal sealed partial class DecisionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DecisionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DecisionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.AnswerJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.AudioMediaProcessingJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.DecisionInputContentJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.DecisionInstructionContentJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.DocumentMediaProcessingJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.MediaProcessingJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.QuestionJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DocumentMediaProcessing?, global::Google.Gemini.NextGen.DocumentContentProcessing?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentProcessing)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentProcessing?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentMimeType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentMimeType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentProcessing)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentProcessing?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentMimeType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentMimeType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ImageContentMimeType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ImageContentMimeType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.MediaResolution)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.MediaResolution?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentProcessing)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentProcessing?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentMimeType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentMimeType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentProcessing))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AudioContentProcessingJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentProcessing?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AudioContentProcessingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentMimeType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AudioContentMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AudioContentMimeType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AudioContentMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DecisionInstructionContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DecisionInstructionContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentProcessing))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DocumentContentProcessingJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentProcessing?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DocumentContentProcessingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentMimeType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DocumentContentMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.DocumentContentMimeType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.DocumentContentMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ImageContentMimeType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ImageContentMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ImageContentMimeType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ImageContentMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.MediaResolution))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.MediaResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.MediaResolution?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.MediaResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PageProcessingOptionsContentLayerJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PageProcessingOptionsContentLayerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PromptFeedbackBlockReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.PromptFeedbackBlockReason?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PromptFeedbackBlockReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ResponseModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ResponseModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.SpreadsheetProcessingOptionsContentLayerJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.SpreadsheetProcessingOptionsContentLayerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.StaticMediaProcessingContentLayerJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.StaticMediaProcessingContentLayerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentProcessing))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VideoContentProcessingJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentProcessing?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VideoContentProcessingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentMimeType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VideoContentMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VideoContentMimeType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VideoContentMimeTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DecisionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}