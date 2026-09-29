#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct StepDeltaData : global::System.IEquatable<StepDeltaData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ArgumentsDelta? Arguments { get; init; }
#else
        public global::Google.Gemini.NextGen.ArgumentsDelta? Arguments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Arguments))]
#endif
        public bool IsArguments => Arguments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArguments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ArgumentsDelta? value)
        {
            value = Arguments;
            return IsArguments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ArgumentsDelta PickArguments() => IsArguments
            ? Arguments!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arguments' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AudioDelta? Audio { get; init; }
#else
        public global::Google.Gemini.NextGen.AudioDelta? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.AudioDelta? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDelta PickAudio() => IsAudio
            ? Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? CodeExecutionCall { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? CodeExecutionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionCall))]
#endif
        public bool IsCodeExecutionCall => CodeExecutionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.CodeExecutionCallDelta? value)
        {
            value = CodeExecutionCall;
            return IsCodeExecutionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta PickCodeExecutionCall() => IsCodeExecutionCall
            ? CodeExecutionCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? CodeExecutionResult { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? CodeExecutionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionResult))]
#endif
        public bool IsCodeExecutionResult => CodeExecutionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.CodeExecutionResultDelta? value)
        {
            value = CodeExecutionResult;
            return IsCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta PickCodeExecutionResult() => IsCodeExecutionResult
            ? CodeExecutionResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.DocumentDelta? Document { get; init; }
#else
        public global::Google.Gemini.NextGen.DocumentDelta? Document { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.DocumentDelta? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDelta PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileSearchCallDelta? FileSearchCall { get; init; }
#else
        public global::Google.Gemini.NextGen.FileSearchCallDelta? FileSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FileSearchCallDelta? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallDelta PickFileSearchCall() => IsFileSearchCall
            ? FileSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileSearchResultDelta? FileSearchResult { get; init; }
#else
        public global::Google.Gemini.NextGen.FileSearchResultDelta? FileSearchResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchResult))]
#endif
        public bool IsFileSearchResult => FileSearchResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FileSearchResultDelta? value)
        {
            value = FileSearchResult;
            return IsFileSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultDelta PickFileSearchResult() => IsFileSearchResult
            ? FileSearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FunctionResultDelta? FunctionResult { get; init; }
#else
        public global::Google.Gemini.NextGen.FunctionResultDelta? FunctionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionResult))]
#endif
        public bool IsFunctionResult => FunctionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FunctionResultDelta? value)
        {
            value = FunctionResult;
            return IsFunctionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta PickFunctionResult() => IsFunctionResult
            ? FunctionResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? GoogleMapsCall { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? GoogleMapsCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleMapsCall))]
#endif
        public bool IsGoogleMapsCall => GoogleMapsCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleMapsCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleMapsCallDelta? value)
        {
            value = GoogleMapsCall;
            return IsGoogleMapsCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta PickGoogleMapsCall() => IsGoogleMapsCall
            ? GoogleMapsCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleMapsCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? GoogleMapsResult { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? GoogleMapsResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleMapsResult))]
#endif
        public bool IsGoogleMapsResult => GoogleMapsResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleMapsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleMapsResultDelta? value)
        {
            value = GoogleMapsResult;
            return IsGoogleMapsResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta PickGoogleMapsResult() => IsGoogleMapsResult
            ? GoogleMapsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleMapsResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? GoogleSearchCall { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? GoogleSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSearchCall))]
#endif
        public bool IsGoogleSearchCall => GoogleSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleSearchCallDelta? value)
        {
            value = GoogleSearchCall;
            return IsGoogleSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta PickGoogleSearchCall() => IsGoogleSearchCall
            ? GoogleSearchCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSearchCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? GoogleSearchResult { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? GoogleSearchResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSearchResult))]
#endif
        public bool IsGoogleSearchResult => GoogleSearchResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleSearchResultDelta? value)
        {
            value = GoogleSearchResult;
            return IsGoogleSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta PickGoogleSearchResult() => IsGoogleSearchResult
            ? GoogleSearchResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSearchResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ImageDelta? Image { get; init; }
#else
        public global::Google.Gemini.NextGen.ImageDelta? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ImageDelta? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.MCPServerToolCallDelta? MCPServerToolCall { get; init; }
#else
        public global::Google.Gemini.NextGen.MCPServerToolCallDelta? MCPServerToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPServerToolCall))]
#endif
        public bool IsMCPServerToolCall => MCPServerToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMCPServerToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.MCPServerToolCallDelta? value)
        {
            value = MCPServerToolCall;
            return IsMCPServerToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallDelta PickMCPServerToolCall() => IsMCPServerToolCall
            ? MCPServerToolCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPServerToolCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.MCPServerToolResultDelta? MCPServerToolResult { get; init; }
#else
        public global::Google.Gemini.NextGen.MCPServerToolResultDelta? MCPServerToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPServerToolResult))]
#endif
        public bool IsMCPServerToolResult => MCPServerToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMCPServerToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.MCPServerToolResultDelta? value)
        {
            value = MCPServerToolResult;
            return IsMCPServerToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultDelta PickMCPServerToolResult() => IsMCPServerToolResult
            ? MCPServerToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPServerToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Streaming delta for a server-initiated media processing step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ProcessingCallDelta? ProcessingCall { get; init; }
#else
        public global::Google.Gemini.NextGen.ProcessingCallDelta? ProcessingCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProcessingCall))]
#endif
        public bool IsProcessingCall => ProcessingCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProcessingCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ProcessingCallDelta? value)
        {
            value = ProcessingCall;
            return IsProcessingCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta PickProcessingCall() => IsProcessingCall
            ? ProcessingCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessingCall' but the value was {ToString()}.");

        /// <summary>
        /// Streaming delta for the result of a server-initiated media processing step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ProcessingResultDelta? ProcessingResult { get; init; }
#else
        public global::Google.Gemini.NextGen.ProcessingResultDelta? ProcessingResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProcessingResult))]
#endif
        public bool IsProcessingResult => ProcessingResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProcessingResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ProcessingResultDelta? value)
        {
            value = ProcessingResult;
            return IsProcessingResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta PickProcessingResult() => IsProcessingResult
            ? ProcessingResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessingResult' but the value was {ToString()}.");

        /// <summary>
        /// Used by Vertex Retrieval tools such as Parallel AI, Exa AI, Vertex AI Search,<br/>
        /// etc. RetrievalType decides which tool is used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.RetrievalCallDelta? RetrievalCall { get; init; }
#else
        public global::Google.Gemini.NextGen.RetrievalCallDelta? RetrievalCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetrievalCall))]
#endif
        public bool IsRetrievalCall => RetrievalCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetrievalCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.RetrievalCallDelta? value)
        {
            value = RetrievalCall;
            return IsRetrievalCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallDelta PickRetrievalCall() => IsRetrievalCall
            ? RetrievalCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetrievalCall' but the value was {ToString()}.");

        /// <summary>
        /// Used by Vertex Retrieval tools such as Parallel AI, Exa AI, Vertex AI Search,<br/>
        /// etc.<br/>
        /// ToolResultDelta.type
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.RetrievalResultDelta? RetrievalResult { get; init; }
#else
        public global::Google.Gemini.NextGen.RetrievalResultDelta? RetrievalResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetrievalResult))]
#endif
        public bool IsRetrievalResult => RetrievalResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetrievalResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.RetrievalResultDelta? value)
        {
            value = RetrievalResult;
            return IsRetrievalResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultDelta PickRetrievalResult() => IsRetrievalResult
            ? RetrievalResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetrievalResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextAnnotationDelta? TextAnnotation { get; init; }
#else
        public global::Google.Gemini.NextGen.TextAnnotationDelta? TextAnnotation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextAnnotation))]
#endif
        public bool IsTextAnnotation => TextAnnotation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextAnnotation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.TextAnnotationDelta? value)
        {
            value = TextAnnotation;
            return IsTextAnnotation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta PickTextAnnotation() => IsTextAnnotation
            ? TextAnnotation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextAnnotation' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextDelta? Text { get; init; }
#else
        public global::Google.Gemini.NextGen.TextDelta? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.TextDelta? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? ThoughtSignature { get; init; }
#else
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? ThoughtSignature { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThoughtSignature))]
#endif
        public bool IsThoughtSignature => ThoughtSignature != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThoughtSignature(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ThoughtSignatureDelta? value)
        {
            value = ThoughtSignature;
            return IsThoughtSignature;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta PickThoughtSignature() => IsThoughtSignature
            ? ThoughtSignature!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThoughtSignature' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? ThoughtSummary { get; init; }
#else
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? ThoughtSummary { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThoughtSummary))]
#endif
        public bool IsThoughtSummary => ThoughtSummary != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThoughtSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ThoughtSummaryDelta? value)
        {
            value = ThoughtSummary;
            return IsThoughtSummary;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta PickThoughtSummary() => IsThoughtSummary
            ? ThoughtSummary!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThoughtSummary' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLContextCallDelta? URLContextCall { get; init; }
#else
        public global::Google.Gemini.NextGen.URLContextCallDelta? URLContextCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(URLContextCall))]
#endif
        public bool IsURLContextCall => URLContextCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickURLContextCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.URLContextCallDelta? value)
        {
            value = URLContextCall;
            return IsURLContextCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta PickURLContextCall() => IsURLContextCall
            ? URLContextCall!
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLContextCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLContextResultDelta? URLContextResult { get; init; }
#else
        public global::Google.Gemini.NextGen.URLContextResultDelta? URLContextResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(URLContextResult))]
#endif
        public bool IsURLContextResult => URLContextResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickURLContextResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.URLContextResultDelta? value)
        {
            value = URLContextResult;
            return IsURLContextResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta PickURLContextResult() => IsURLContextResult
            ? URLContextResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLContextResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.VideoDelta? Video { get; init; }
#else
        public global::Google.Gemini.NextGen.VideoDelta? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.VideoDelta? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ArgumentsDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ArgumentsDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ArgumentsDelta?(StepDeltaData @this) => @this.Arguments;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ArgumentsDelta? value)
        {
            Arguments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromArguments(global::Google.Gemini.NextGen.ArgumentsDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.AudioDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.AudioDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AudioDelta?(StepDeltaData @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.AudioDelta? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromAudio(global::Google.Gemini.NextGen.AudioDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.CodeExecutionCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.CodeExecutionCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecutionCallDelta?(StepDeltaData @this) => @this.CodeExecutionCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.CodeExecutionCallDelta? value)
        {
            CodeExecutionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromCodeExecutionCall(global::Google.Gemini.NextGen.CodeExecutionCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.CodeExecutionResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.CodeExecutionResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecutionResultDelta?(StepDeltaData @this) => @this.CodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.CodeExecutionResultDelta? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromCodeExecutionResult(global::Google.Gemini.NextGen.CodeExecutionResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.DocumentDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.DocumentDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.DocumentDelta?(StepDeltaData @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.DocumentDelta? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromDocument(global::Google.Gemini.NextGen.DocumentDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.FileSearchCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.FileSearchCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileSearchCallDelta?(StepDeltaData @this) => @this.FileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.FileSearchCallDelta? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromFileSearchCall(global::Google.Gemini.NextGen.FileSearchCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.FileSearchResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.FileSearchResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileSearchResultDelta?(StepDeltaData @this) => @this.FileSearchResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.FileSearchResultDelta? value)
        {
            FileSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromFileSearchResult(global::Google.Gemini.NextGen.FileSearchResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.FunctionResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.FunctionResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FunctionResultDelta?(StepDeltaData @this) => @this.FunctionResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.FunctionResultDelta? value)
        {
            FunctionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromFunctionResult(global::Google.Gemini.NextGen.FunctionResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.GoogleMapsCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.GoogleMapsCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleMapsCallDelta?(StepDeltaData @this) => @this.GoogleMapsCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.GoogleMapsCallDelta? value)
        {
            GoogleMapsCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromGoogleMapsCall(global::Google.Gemini.NextGen.GoogleMapsCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.GoogleMapsResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.GoogleMapsResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleMapsResultDelta?(StepDeltaData @this) => @this.GoogleMapsResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.GoogleMapsResultDelta? value)
        {
            GoogleMapsResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromGoogleMapsResult(global::Google.Gemini.NextGen.GoogleMapsResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.GoogleSearchCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.GoogleSearchCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearchCallDelta?(StepDeltaData @this) => @this.GoogleSearchCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.GoogleSearchCallDelta? value)
        {
            GoogleSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromGoogleSearchCall(global::Google.Gemini.NextGen.GoogleSearchCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.GoogleSearchResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.GoogleSearchResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearchResultDelta?(StepDeltaData @this) => @this.GoogleSearchResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.GoogleSearchResultDelta? value)
        {
            GoogleSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromGoogleSearchResult(global::Google.Gemini.NextGen.GoogleSearchResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ImageDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ImageDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageDelta?(StepDeltaData @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ImageDelta? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromImage(global::Google.Gemini.NextGen.ImageDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.MCPServerToolCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.MCPServerToolCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.MCPServerToolCallDelta?(StepDeltaData @this) => @this.MCPServerToolCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.MCPServerToolCallDelta? value)
        {
            MCPServerToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromMCPServerToolCall(global::Google.Gemini.NextGen.MCPServerToolCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.MCPServerToolResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.MCPServerToolResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.MCPServerToolResultDelta?(StepDeltaData @this) => @this.MCPServerToolResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.MCPServerToolResultDelta? value)
        {
            MCPServerToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromMCPServerToolResult(global::Google.Gemini.NextGen.MCPServerToolResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ProcessingCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ProcessingCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ProcessingCallDelta?(StepDeltaData @this) => @this.ProcessingCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ProcessingCallDelta? value)
        {
            ProcessingCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromProcessingCall(global::Google.Gemini.NextGen.ProcessingCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ProcessingResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ProcessingResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ProcessingResultDelta?(StepDeltaData @this) => @this.ProcessingResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ProcessingResultDelta? value)
        {
            ProcessingResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromProcessingResult(global::Google.Gemini.NextGen.ProcessingResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.RetrievalCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.RetrievalCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.RetrievalCallDelta?(StepDeltaData @this) => @this.RetrievalCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.RetrievalCallDelta? value)
        {
            RetrievalCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromRetrievalCall(global::Google.Gemini.NextGen.RetrievalCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.RetrievalResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.RetrievalResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.RetrievalResultDelta?(StepDeltaData @this) => @this.RetrievalResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.RetrievalResultDelta? value)
        {
            RetrievalResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromRetrievalResult(global::Google.Gemini.NextGen.RetrievalResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.TextAnnotationDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.TextAnnotationDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextAnnotationDelta?(StepDeltaData @this) => @this.TextAnnotation;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.TextAnnotationDelta? value)
        {
            TextAnnotation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromTextAnnotation(global::Google.Gemini.NextGen.TextAnnotationDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.TextDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.TextDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextDelta?(StepDeltaData @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.TextDelta? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromText(global::Google.Gemini.NextGen.TextDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ThoughtSignatureDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ThoughtSignatureDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ThoughtSignatureDelta?(StepDeltaData @this) => @this.ThoughtSignature;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ThoughtSignatureDelta? value)
        {
            ThoughtSignature = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromThoughtSignature(global::Google.Gemini.NextGen.ThoughtSignatureDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.ThoughtSummaryDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.ThoughtSummaryDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ThoughtSummaryDelta?(StepDeltaData @this) => @this.ThoughtSummary;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.ThoughtSummaryDelta? value)
        {
            ThoughtSummary = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromThoughtSummary(global::Google.Gemini.NextGen.ThoughtSummaryDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.URLContextCallDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.URLContextCallDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContextCallDelta?(StepDeltaData @this) => @this.URLContextCall;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.URLContextCallDelta? value)
        {
            URLContextCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromURLContextCall(global::Google.Gemini.NextGen.URLContextCallDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.URLContextResultDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.URLContextResultDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContextResultDelta?(StepDeltaData @this) => @this.URLContextResult;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.URLContextResultDelta? value)
        {
            URLContextResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromURLContextResult(global::Google.Gemini.NextGen.URLContextResultDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepDeltaData(global::Google.Gemini.NextGen.VideoDelta value) => new StepDeltaData((global::Google.Gemini.NextGen.VideoDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.VideoDelta?(StepDeltaData @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(global::Google.Gemini.NextGen.VideoDelta? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepDeltaData FromVideo(global::Google.Gemini.NextGen.VideoDelta? value) => new StepDeltaData(value);

        /// <summary>
        ///
        /// </summary>
        public StepDeltaData(
            global::Google.Gemini.NextGen.ArgumentsDelta? arguments,
            global::Google.Gemini.NextGen.AudioDelta? audio,
            global::Google.Gemini.NextGen.CodeExecutionCallDelta? codeExecutionCall,
            global::Google.Gemini.NextGen.CodeExecutionResultDelta? codeExecutionResult,
            global::Google.Gemini.NextGen.DocumentDelta? document,
            global::Google.Gemini.NextGen.FileSearchCallDelta? fileSearchCall,
            global::Google.Gemini.NextGen.FileSearchResultDelta? fileSearchResult,
            global::Google.Gemini.NextGen.FunctionResultDelta? functionResult,
            global::Google.Gemini.NextGen.GoogleMapsCallDelta? googleMapsCall,
            global::Google.Gemini.NextGen.GoogleMapsResultDelta? googleMapsResult,
            global::Google.Gemini.NextGen.GoogleSearchCallDelta? googleSearchCall,
            global::Google.Gemini.NextGen.GoogleSearchResultDelta? googleSearchResult,
            global::Google.Gemini.NextGen.ImageDelta? image,
            global::Google.Gemini.NextGen.MCPServerToolCallDelta? mCPServerToolCall,
            global::Google.Gemini.NextGen.MCPServerToolResultDelta? mCPServerToolResult,
            global::Google.Gemini.NextGen.ProcessingCallDelta? processingCall,
            global::Google.Gemini.NextGen.ProcessingResultDelta? processingResult,
            global::Google.Gemini.NextGen.RetrievalCallDelta? retrievalCall,
            global::Google.Gemini.NextGen.RetrievalResultDelta? retrievalResult,
            global::Google.Gemini.NextGen.TextAnnotationDelta? textAnnotation,
            global::Google.Gemini.NextGen.TextDelta? text,
            global::Google.Gemini.NextGen.ThoughtSignatureDelta? thoughtSignature,
            global::Google.Gemini.NextGen.ThoughtSummaryDelta? thoughtSummary,
            global::Google.Gemini.NextGen.URLContextCallDelta? uRLContextCall,
            global::Google.Gemini.NextGen.URLContextResultDelta? uRLContextResult,
            global::Google.Gemini.NextGen.VideoDelta? video
            )
        {
            Arguments = arguments;
            Audio = audio;
            CodeExecutionCall = codeExecutionCall;
            CodeExecutionResult = codeExecutionResult;
            Document = document;
            FileSearchCall = fileSearchCall;
            FileSearchResult = fileSearchResult;
            FunctionResult = functionResult;
            GoogleMapsCall = googleMapsCall;
            GoogleMapsResult = googleMapsResult;
            GoogleSearchCall = googleSearchCall;
            GoogleSearchResult = googleSearchResult;
            Image = image;
            MCPServerToolCall = mCPServerToolCall;
            MCPServerToolResult = mCPServerToolResult;
            ProcessingCall = processingCall;
            ProcessingResult = processingResult;
            RetrievalCall = retrievalCall;
            RetrievalResult = retrievalResult;
            TextAnnotation = textAnnotation;
            Text = text;
            ThoughtSignature = thoughtSignature;
            ThoughtSummary = thoughtSummary;
            URLContextCall = uRLContextCall;
            URLContextResult = uRLContextResult;
            Video = video;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Video as object ??
            URLContextResult as object ??
            URLContextCall as object ??
            ThoughtSummary as object ??
            ThoughtSignature as object ??
            Text as object ??
            TextAnnotation as object ??
            RetrievalResult as object ??
            RetrievalCall as object ??
            ProcessingResult as object ??
            ProcessingCall as object ??
            MCPServerToolResult as object ??
            MCPServerToolCall as object ??
            Image as object ??
            GoogleSearchResult as object ??
            GoogleSearchCall as object ??
            GoogleMapsResult as object ??
            GoogleMapsCall as object ??
            FunctionResult as object ??
            FileSearchResult as object ??
            FileSearchCall as object ??
            Document as object ??
            CodeExecutionResult as object ??
            CodeExecutionCall as object ??
            Audio as object ??
            Arguments as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Arguments?.ToString() ??
            Audio?.ToString() ??
            CodeExecutionCall?.ToString() ??
            CodeExecutionResult?.ToString() ??
            Document?.ToString() ??
            FileSearchCall?.ToString() ??
            FileSearchResult?.ToString() ??
            FunctionResult?.ToString() ??
            GoogleMapsCall?.ToString() ??
            GoogleMapsResult?.ToString() ??
            GoogleSearchCall?.ToString() ??
            GoogleSearchResult?.ToString() ??
            Image?.ToString() ??
            MCPServerToolCall?.ToString() ??
            MCPServerToolResult?.ToString() ??
            ProcessingCall?.ToString() ??
            ProcessingResult?.ToString() ??
            RetrievalCall?.ToString() ??
            RetrievalResult?.ToString() ??
            TextAnnotation?.ToString() ??
            Text?.ToString() ??
            ThoughtSignature?.ToString() ??
            ThoughtSummary?.ToString() ??
            URLContextCall?.ToString() ??
            URLContextResult?.ToString() ??
            Video?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && IsURLContextCall && !IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && IsURLContextResult && !IsVideo || !IsArguments && !IsAudio && !IsCodeExecutionCall && !IsCodeExecutionResult && !IsDocument && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsImage && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsTextAnnotation && !IsText && !IsThoughtSignature && !IsThoughtSummary && !IsURLContextCall && !IsURLContextResult && IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.ArgumentsDelta, TResult>? arguments = null,
            global::System.Func<global::Google.Gemini.NextGen.AudioDelta, TResult>? audio = null,
            global::System.Func<global::Google.Gemini.NextGen.CodeExecutionCallDelta, TResult>? codeExecutionCall = null,
            global::System.Func<global::Google.Gemini.NextGen.CodeExecutionResultDelta, TResult>? codeExecutionResult = null,
            global::System.Func<global::Google.Gemini.NextGen.DocumentDelta, TResult>? document = null,
            global::System.Func<global::Google.Gemini.NextGen.FileSearchCallDelta, TResult>? fileSearchCall = null,
            global::System.Func<global::Google.Gemini.NextGen.FileSearchResultDelta, TResult>? fileSearchResult = null,
            global::System.Func<global::Google.Gemini.NextGen.FunctionResultDelta, TResult>? functionResult = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleMapsCallDelta, TResult>? googleMapsCall = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleMapsResultDelta, TResult>? googleMapsResult = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearchCallDelta, TResult>? googleSearchCall = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearchResultDelta, TResult>? googleSearchResult = null,
            global::System.Func<global::Google.Gemini.NextGen.ImageDelta, TResult>? image = null,
            global::System.Func<global::Google.Gemini.NextGen.MCPServerToolCallDelta, TResult>? mCPServerToolCall = null,
            global::System.Func<global::Google.Gemini.NextGen.MCPServerToolResultDelta, TResult>? mCPServerToolResult = null,
            global::System.Func<global::Google.Gemini.NextGen.ProcessingCallDelta, TResult>? processingCall = null,
            global::System.Func<global::Google.Gemini.NextGen.ProcessingResultDelta, TResult>? processingResult = null,
            global::System.Func<global::Google.Gemini.NextGen.RetrievalCallDelta, TResult>? retrievalCall = null,
            global::System.Func<global::Google.Gemini.NextGen.RetrievalResultDelta, TResult>? retrievalResult = null,
            global::System.Func<global::Google.Gemini.NextGen.TextAnnotationDelta, TResult>? textAnnotation = null,
            global::System.Func<global::Google.Gemini.NextGen.TextDelta, TResult>? text = null,
            global::System.Func<global::Google.Gemini.NextGen.ThoughtSignatureDelta, TResult>? thoughtSignature = null,
            global::System.Func<global::Google.Gemini.NextGen.ThoughtSummaryDelta, TResult>? thoughtSummary = null,
            global::System.Func<global::Google.Gemini.NextGen.URLContextCallDelta, TResult>? uRLContextCall = null,
            global::System.Func<global::Google.Gemini.NextGen.URLContextResultDelta, TResult>? uRLContextResult = null,
            global::System.Func<global::Google.Gemini.NextGen.VideoDelta, TResult>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArguments && arguments != null)
            {
                return arguments(Arguments!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsCodeExecutionCall && codeExecutionCall != null)
            {
                return codeExecutionCall(CodeExecutionCall!);
            }
            else if (IsCodeExecutionResult && codeExecutionResult != null)
            {
                return codeExecutionResult(CodeExecutionResult!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsFileSearchResult && fileSearchResult != null)
            {
                return fileSearchResult(FileSearchResult!);
            }
            else if (IsFunctionResult && functionResult != null)
            {
                return functionResult(FunctionResult!);
            }
            else if (IsGoogleMapsCall && googleMapsCall != null)
            {
                return googleMapsCall(GoogleMapsCall!);
            }
            else if (IsGoogleMapsResult && googleMapsResult != null)
            {
                return googleMapsResult(GoogleMapsResult!);
            }
            else if (IsGoogleSearchCall && googleSearchCall != null)
            {
                return googleSearchCall(GoogleSearchCall!);
            }
            else if (IsGoogleSearchResult && googleSearchResult != null)
            {
                return googleSearchResult(GoogleSearchResult!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsMCPServerToolCall && mCPServerToolCall != null)
            {
                return mCPServerToolCall(MCPServerToolCall!);
            }
            else if (IsMCPServerToolResult && mCPServerToolResult != null)
            {
                return mCPServerToolResult(MCPServerToolResult!);
            }
            else if (IsProcessingCall && processingCall != null)
            {
                return processingCall(ProcessingCall!);
            }
            else if (IsProcessingResult && processingResult != null)
            {
                return processingResult(ProcessingResult!);
            }
            else if (IsRetrievalCall && retrievalCall != null)
            {
                return retrievalCall(RetrievalCall!);
            }
            else if (IsRetrievalResult && retrievalResult != null)
            {
                return retrievalResult(RetrievalResult!);
            }
            else if (IsTextAnnotation && textAnnotation != null)
            {
                return textAnnotation(TextAnnotation!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsThoughtSignature && thoughtSignature != null)
            {
                return thoughtSignature(ThoughtSignature!);
            }
            else if (IsThoughtSummary && thoughtSummary != null)
            {
                return thoughtSummary(ThoughtSummary!);
            }
            else if (IsURLContextCall && uRLContextCall != null)
            {
                return uRLContextCall(URLContextCall!);
            }
            else if (IsURLContextResult && uRLContextResult != null)
            {
                return uRLContextResult(URLContextResult!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.ArgumentsDelta>? arguments = null,

            global::System.Action<global::Google.Gemini.NextGen.AudioDelta>? audio = null,

            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionCallDelta>? codeExecutionCall = null,

            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionResultDelta>? codeExecutionResult = null,

            global::System.Action<global::Google.Gemini.NextGen.DocumentDelta>? document = null,

            global::System.Action<global::Google.Gemini.NextGen.FileSearchCallDelta>? fileSearchCall = null,

            global::System.Action<global::Google.Gemini.NextGen.FileSearchResultDelta>? fileSearchResult = null,

            global::System.Action<global::Google.Gemini.NextGen.FunctionResultDelta>? functionResult = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsCallDelta>? googleMapsCall = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsResultDelta>? googleMapsResult = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchCallDelta>? googleSearchCall = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchResultDelta>? googleSearchResult = null,

            global::System.Action<global::Google.Gemini.NextGen.ImageDelta>? image = null,

            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolCallDelta>? mCPServerToolCall = null,

            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolResultDelta>? mCPServerToolResult = null,

            global::System.Action<global::Google.Gemini.NextGen.ProcessingCallDelta>? processingCall = null,

            global::System.Action<global::Google.Gemini.NextGen.ProcessingResultDelta>? processingResult = null,

            global::System.Action<global::Google.Gemini.NextGen.RetrievalCallDelta>? retrievalCall = null,

            global::System.Action<global::Google.Gemini.NextGen.RetrievalResultDelta>? retrievalResult = null,

            global::System.Action<global::Google.Gemini.NextGen.TextAnnotationDelta>? textAnnotation = null,

            global::System.Action<global::Google.Gemini.NextGen.TextDelta>? text = null,

            global::System.Action<global::Google.Gemini.NextGen.ThoughtSignatureDelta>? thoughtSignature = null,

            global::System.Action<global::Google.Gemini.NextGen.ThoughtSummaryDelta>? thoughtSummary = null,

            global::System.Action<global::Google.Gemini.NextGen.URLContextCallDelta>? uRLContextCall = null,

            global::System.Action<global::Google.Gemini.NextGen.URLContextResultDelta>? uRLContextResult = null,

            global::System.Action<global::Google.Gemini.NextGen.VideoDelta>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArguments)
            {
                arguments?.Invoke(Arguments!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsCodeExecutionCall)
            {
                codeExecutionCall?.Invoke(CodeExecutionCall!);
            }
            else if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFileSearchResult)
            {
                fileSearchResult?.Invoke(FileSearchResult!);
            }
            else if (IsFunctionResult)
            {
                functionResult?.Invoke(FunctionResult!);
            }
            else if (IsGoogleMapsCall)
            {
                googleMapsCall?.Invoke(GoogleMapsCall!);
            }
            else if (IsGoogleMapsResult)
            {
                googleMapsResult?.Invoke(GoogleMapsResult!);
            }
            else if (IsGoogleSearchCall)
            {
                googleSearchCall?.Invoke(GoogleSearchCall!);
            }
            else if (IsGoogleSearchResult)
            {
                googleSearchResult?.Invoke(GoogleSearchResult!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMCPServerToolCall)
            {
                mCPServerToolCall?.Invoke(MCPServerToolCall!);
            }
            else if (IsMCPServerToolResult)
            {
                mCPServerToolResult?.Invoke(MCPServerToolResult!);
            }
            else if (IsProcessingCall)
            {
                processingCall?.Invoke(ProcessingCall!);
            }
            else if (IsProcessingResult)
            {
                processingResult?.Invoke(ProcessingResult!);
            }
            else if (IsRetrievalCall)
            {
                retrievalCall?.Invoke(RetrievalCall!);
            }
            else if (IsRetrievalResult)
            {
                retrievalResult?.Invoke(RetrievalResult!);
            }
            else if (IsTextAnnotation)
            {
                textAnnotation?.Invoke(TextAnnotation!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsThoughtSignature)
            {
                thoughtSignature?.Invoke(ThoughtSignature!);
            }
            else if (IsThoughtSummary)
            {
                thoughtSummary?.Invoke(ThoughtSummary!);
            }
            else if (IsURLContextCall)
            {
                uRLContextCall?.Invoke(URLContextCall!);
            }
            else if (IsURLContextResult)
            {
                uRLContextResult?.Invoke(URLContextResult!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.ArgumentsDelta>? arguments = null,
            global::System.Action<global::Google.Gemini.NextGen.AudioDelta>? audio = null,
            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionCallDelta>? codeExecutionCall = null,
            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionResultDelta>? codeExecutionResult = null,
            global::System.Action<global::Google.Gemini.NextGen.DocumentDelta>? document = null,
            global::System.Action<global::Google.Gemini.NextGen.FileSearchCallDelta>? fileSearchCall = null,
            global::System.Action<global::Google.Gemini.NextGen.FileSearchResultDelta>? fileSearchResult = null,
            global::System.Action<global::Google.Gemini.NextGen.FunctionResultDelta>? functionResult = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsCallDelta>? googleMapsCall = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsResultDelta>? googleMapsResult = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchCallDelta>? googleSearchCall = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchResultDelta>? googleSearchResult = null,
            global::System.Action<global::Google.Gemini.NextGen.ImageDelta>? image = null,
            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolCallDelta>? mCPServerToolCall = null,
            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolResultDelta>? mCPServerToolResult = null,
            global::System.Action<global::Google.Gemini.NextGen.ProcessingCallDelta>? processingCall = null,
            global::System.Action<global::Google.Gemini.NextGen.ProcessingResultDelta>? processingResult = null,
            global::System.Action<global::Google.Gemini.NextGen.RetrievalCallDelta>? retrievalCall = null,
            global::System.Action<global::Google.Gemini.NextGen.RetrievalResultDelta>? retrievalResult = null,
            global::System.Action<global::Google.Gemini.NextGen.TextAnnotationDelta>? textAnnotation = null,
            global::System.Action<global::Google.Gemini.NextGen.TextDelta>? text = null,
            global::System.Action<global::Google.Gemini.NextGen.ThoughtSignatureDelta>? thoughtSignature = null,
            global::System.Action<global::Google.Gemini.NextGen.ThoughtSummaryDelta>? thoughtSummary = null,
            global::System.Action<global::Google.Gemini.NextGen.URLContextCallDelta>? uRLContextCall = null,
            global::System.Action<global::Google.Gemini.NextGen.URLContextResultDelta>? uRLContextResult = null,
            global::System.Action<global::Google.Gemini.NextGen.VideoDelta>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArguments)
            {
                arguments?.Invoke(Arguments!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsCodeExecutionCall)
            {
                codeExecutionCall?.Invoke(CodeExecutionCall!);
            }
            else if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFileSearchResult)
            {
                fileSearchResult?.Invoke(FileSearchResult!);
            }
            else if (IsFunctionResult)
            {
                functionResult?.Invoke(FunctionResult!);
            }
            else if (IsGoogleMapsCall)
            {
                googleMapsCall?.Invoke(GoogleMapsCall!);
            }
            else if (IsGoogleMapsResult)
            {
                googleMapsResult?.Invoke(GoogleMapsResult!);
            }
            else if (IsGoogleSearchCall)
            {
                googleSearchCall?.Invoke(GoogleSearchCall!);
            }
            else if (IsGoogleSearchResult)
            {
                googleSearchResult?.Invoke(GoogleSearchResult!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMCPServerToolCall)
            {
                mCPServerToolCall?.Invoke(MCPServerToolCall!);
            }
            else if (IsMCPServerToolResult)
            {
                mCPServerToolResult?.Invoke(MCPServerToolResult!);
            }
            else if (IsProcessingCall)
            {
                processingCall?.Invoke(ProcessingCall!);
            }
            else if (IsProcessingResult)
            {
                processingResult?.Invoke(ProcessingResult!);
            }
            else if (IsRetrievalCall)
            {
                retrievalCall?.Invoke(RetrievalCall!);
            }
            else if (IsRetrievalResult)
            {
                retrievalResult?.Invoke(RetrievalResult!);
            }
            else if (IsTextAnnotation)
            {
                textAnnotation?.Invoke(TextAnnotation!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsThoughtSignature)
            {
                thoughtSignature?.Invoke(ThoughtSignature!);
            }
            else if (IsThoughtSummary)
            {
                thoughtSummary?.Invoke(ThoughtSummary!);
            }
            else if (IsURLContextCall)
            {
                uRLContextCall?.Invoke(URLContextCall!);
            }
            else if (IsURLContextResult)
            {
                uRLContextResult?.Invoke(URLContextResult!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Arguments,
                typeof(global::Google.Gemini.NextGen.ArgumentsDelta),
                Audio,
                typeof(global::Google.Gemini.NextGen.AudioDelta),
                CodeExecutionCall,
                typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta),
                CodeExecutionResult,
                typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta),
                Document,
                typeof(global::Google.Gemini.NextGen.DocumentDelta),
                FileSearchCall,
                typeof(global::Google.Gemini.NextGen.FileSearchCallDelta),
                FileSearchResult,
                typeof(global::Google.Gemini.NextGen.FileSearchResultDelta),
                FunctionResult,
                typeof(global::Google.Gemini.NextGen.FunctionResultDelta),
                GoogleMapsCall,
                typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta),
                GoogleMapsResult,
                typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta),
                GoogleSearchCall,
                typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta),
                GoogleSearchResult,
                typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta),
                Image,
                typeof(global::Google.Gemini.NextGen.ImageDelta),
                MCPServerToolCall,
                typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta),
                MCPServerToolResult,
                typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta),
                ProcessingCall,
                typeof(global::Google.Gemini.NextGen.ProcessingCallDelta),
                ProcessingResult,
                typeof(global::Google.Gemini.NextGen.ProcessingResultDelta),
                RetrievalCall,
                typeof(global::Google.Gemini.NextGen.RetrievalCallDelta),
                RetrievalResult,
                typeof(global::Google.Gemini.NextGen.RetrievalResultDelta),
                TextAnnotation,
                typeof(global::Google.Gemini.NextGen.TextAnnotationDelta),
                Text,
                typeof(global::Google.Gemini.NextGen.TextDelta),
                ThoughtSignature,
                typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta),
                ThoughtSummary,
                typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta),
                URLContextCall,
                typeof(global::Google.Gemini.NextGen.URLContextCallDelta),
                URLContextResult,
                typeof(global::Google.Gemini.NextGen.URLContextResultDelta),
                Video,
                typeof(global::Google.Gemini.NextGen.VideoDelta),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(StepDeltaData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ArgumentsDelta?>.Default.Equals(Arguments, other.Arguments) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AudioDelta?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecutionCallDelta?>.Default.Equals(CodeExecutionCall, other.CodeExecutionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecutionResultDelta?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.DocumentDelta?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileSearchCallDelta?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileSearchResultDelta?>.Default.Equals(FileSearchResult, other.FileSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FunctionResultDelta?>.Default.Equals(FunctionResult, other.FunctionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleMapsCallDelta?>.Default.Equals(GoogleMapsCall, other.GoogleMapsCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleMapsResultDelta?>.Default.Equals(GoogleMapsResult, other.GoogleMapsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearchCallDelta?>.Default.Equals(GoogleSearchCall, other.GoogleSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearchResultDelta?>.Default.Equals(GoogleSearchResult, other.GoogleSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageDelta?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.MCPServerToolCallDelta?>.Default.Equals(MCPServerToolCall, other.MCPServerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.MCPServerToolResultDelta?>.Default.Equals(MCPServerToolResult, other.MCPServerToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ProcessingCallDelta?>.Default.Equals(ProcessingCall, other.ProcessingCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ProcessingResultDelta?>.Default.Equals(ProcessingResult, other.ProcessingResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.RetrievalCallDelta?>.Default.Equals(RetrievalCall, other.RetrievalCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.RetrievalResultDelta?>.Default.Equals(RetrievalResult, other.RetrievalResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextAnnotationDelta?>.Default.Equals(TextAnnotation, other.TextAnnotation) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextDelta?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ThoughtSignatureDelta?>.Default.Equals(ThoughtSignature, other.ThoughtSignature) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ThoughtSummaryDelta?>.Default.Equals(ThoughtSummary, other.ThoughtSummary) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContextCallDelta?>.Default.Equals(URLContextCall, other.URLContextCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContextResultDelta?>.Default.Equals(URLContextResult, other.URLContextResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.VideoDelta?>.Default.Equals(Video, other.Video)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepDeltaData obj1, StepDeltaData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepDeltaData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepDeltaData obj1, StepDeltaData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepDeltaData o && Equals(o);
        }
    }
}
