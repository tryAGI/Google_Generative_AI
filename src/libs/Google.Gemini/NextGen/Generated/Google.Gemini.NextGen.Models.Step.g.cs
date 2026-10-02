#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A step in the interaction.
    /// </summary>
    public readonly partial struct Step : global::System.IEquatable<Step>
    {
        /// <summary>
        /// Code execution call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? CodeExecutionCall { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? CodeExecutionCall { get; }
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
            out global::Google.Gemini.NextGen.CodeExecutionCallStep? value)
        {
            value = CodeExecutionCall;
            return IsCodeExecutionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallStep PickCodeExecutionCall() => CodeExecutionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionCall' but the value was {ToString()}.");

        /// <summary>
        /// Code execution result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? CodeExecutionResult { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? CodeExecutionResult { get; }
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
            out global::Google.Gemini.NextGen.CodeExecutionResultStep? value)
        {
            value = CodeExecutionResult;
            return IsCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultStep PickCodeExecutionResult() => CodeExecutionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionResult' but the value was {ToString()}.");

        /// <summary>
        /// File Search call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileSearchCallStep? FileSearchCall { get; init; }
#else
        public global::Google.Gemini.NextGen.FileSearchCallStep? FileSearchCall { get; }
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
            out global::Google.Gemini.NextGen.FileSearchCallStep? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallStep PickFileSearchCall() => FileSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// File Search result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileSearchResultStep? FileSearchResult { get; init; }
#else
        public global::Google.Gemini.NextGen.FileSearchResultStep? FileSearchResult { get; }
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
            out global::Google.Gemini.NextGen.FileSearchResultStep? value)
        {
            value = FileSearchResult;
            return IsFileSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultStep PickFileSearchResult() => FileSearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchResult' but the value was {ToString()}.");

        /// <summary>
        /// A function tool call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FunctionCallStep? FunctionCall { get; init; }
#else
        public global::Google.Gemini.NextGen.FunctionCallStep? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FunctionCallStep? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// Result of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FunctionResultStep? FunctionResult { get; init; }
#else
        public global::Google.Gemini.NextGen.FunctionResultStep? FunctionResult { get; }
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
            out global::Google.Gemini.NextGen.FunctionResultStep? value)
        {
            value = FunctionResult;
            return IsFunctionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep PickFunctionResult() => FunctionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionResult' but the value was {ToString()}.");

        /// <summary>
        /// Google Maps call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? GoogleMapsCall { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? GoogleMapsCall { get; }
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
            out global::Google.Gemini.NextGen.GoogleMapsCallStep? value)
        {
            value = GoogleMapsCall;
            return IsGoogleMapsCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep PickGoogleMapsCall() => GoogleMapsCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleMapsCall' but the value was {ToString()}.");

        /// <summary>
        /// Google Maps result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? GoogleMapsResult { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? GoogleMapsResult { get; }
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
            out global::Google.Gemini.NextGen.GoogleMapsResultStep? value)
        {
            value = GoogleMapsResult;
            return IsGoogleMapsResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep PickGoogleMapsResult() => GoogleMapsResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleMapsResult' but the value was {ToString()}.");

        /// <summary>
        /// Google Search call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? GoogleSearchCall { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? GoogleSearchCall { get; }
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
            out global::Google.Gemini.NextGen.GoogleSearchCallStep? value)
        {
            value = GoogleSearchCall;
            return IsGoogleSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep PickGoogleSearchCall() => GoogleSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// Google Search result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? GoogleSearchResult { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? GoogleSearchResult { get; }
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
            out global::Google.Gemini.NextGen.GoogleSearchResultStep? value)
        {
            value = GoogleSearchResult;
            return IsGoogleSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep PickGoogleSearchResult() => GoogleSearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSearchResult' but the value was {ToString()}.");

        /// <summary>
        /// MCPServer tool call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.MCPServerToolCallStep? MCPServerToolCall { get; init; }
#else
        public global::Google.Gemini.NextGen.MCPServerToolCallStep? MCPServerToolCall { get; }
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
            out global::Google.Gemini.NextGen.MCPServerToolCallStep? value)
        {
            value = MCPServerToolCall;
            return IsMCPServerToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallStep PickMCPServerToolCall() => MCPServerToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPServerToolCall' but the value was {ToString()}.");

        /// <summary>
        /// MCPServer tool result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.MCPServerToolResultStep? MCPServerToolResult { get; init; }
#else
        public global::Google.Gemini.NextGen.MCPServerToolResultStep? MCPServerToolResult { get; }
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
            out global::Google.Gemini.NextGen.MCPServerToolResultStep? value)
        {
            value = MCPServerToolResult;
            return IsMCPServerToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultStep PickMCPServerToolResult() => MCPServerToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPServerToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Output generated by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ModelOutputStep? ModelOutput { get; init; }
#else
        public global::Google.Gemini.NextGen.ModelOutputStep? ModelOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutput))]
#endif
        public bool IsModelOutput => ModelOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ModelOutputStep? value)
        {
            value = ModelOutput;
            return IsModelOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep PickModelOutput() => ModelOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutput' but the value was {ToString()}.");

        /// <summary>
        /// A server-initiated processing step for media analysis (e.g. video<br/>
        /// understanding).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ProcessingCallStep? ProcessingCall { get; init; }
#else
        public global::Google.Gemini.NextGen.ProcessingCallStep? ProcessingCall { get; }
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
            out global::Google.Gemini.NextGen.ProcessingCallStep? value)
        {
            value = ProcessingCall;
            return IsProcessingCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep PickProcessingCall() => ProcessingCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessingCall' but the value was {ToString()}.");

        /// <summary>
        /// The result of a server-initiated media processing step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ProcessingResultStep? ProcessingResult { get; init; }
#else
        public global::Google.Gemini.NextGen.ProcessingResultStep? ProcessingResult { get; }
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
            out global::Google.Gemini.NextGen.ProcessingResultStep? value)
        {
            value = ProcessingResult;
            return IsProcessingResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep PickProcessingResult() => ProcessingResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProcessingResult' but the value was {ToString()}.");

        /// <summary>
        /// Retrieval call step.<br/>
        /// Used by Vertex Retrieval tools such as Parallel AI, Exa AI, Vertex AI Search,<br/>
        /// etc. RetrievalType decides which tool is used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.RetrievalCallStep? RetrievalCall { get; init; }
#else
        public global::Google.Gemini.NextGen.RetrievalCallStep? RetrievalCall { get; }
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
            out global::Google.Gemini.NextGen.RetrievalCallStep? value)
        {
            value = RetrievalCall;
            return IsRetrievalCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallStep PickRetrievalCall() => RetrievalCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetrievalCall' but the value was {ToString()}.");

        /// <summary>
        /// Vertex Retrieval result step.<br/>
        /// Used by Vertex Retrieval tools such as Parallel AI, Exa AI, Vertex AI Search,<br/>
        /// etc.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.RetrievalResultStep? RetrievalResult { get; init; }
#else
        public global::Google.Gemini.NextGen.RetrievalResultStep? RetrievalResult { get; }
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
            out global::Google.Gemini.NextGen.RetrievalResultStep? value)
        {
            value = RetrievalResult;
            return IsRetrievalResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultStep PickRetrievalResult() => RetrievalResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetrievalResult' but the value was {ToString()}.");

        /// <summary>
        /// A thought step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ThoughtStep? Thought { get; init; }
#else
        public global::Google.Gemini.NextGen.ThoughtStep? Thought { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thought))]
#endif
        public bool IsThought => Thought != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThought(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ThoughtStep? value)
        {
            value = Thought;
            return IsThought;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep PickThought() => Thought is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thought' but the value was {ToString()}.");

        /// <summary>
        /// URL context call step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLContextCallStep? URLContextCall { get; init; }
#else
        public global::Google.Gemini.NextGen.URLContextCallStep? URLContextCall { get; }
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
            out global::Google.Gemini.NextGen.URLContextCallStep? value)
        {
            value = URLContextCall;
            return IsURLContextCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep PickURLContextCall() => URLContextCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLContextCall' but the value was {ToString()}.");

        /// <summary>
        /// URL context result step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLContextResultStep? URLContextResult { get; init; }
#else
        public global::Google.Gemini.NextGen.URLContextResultStep? URLContextResult { get; }
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
            out global::Google.Gemini.NextGen.URLContextResultStep? value)
        {
            value = URLContextResult;
            return IsURLContextResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep PickURLContextResult() => URLContextResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLContextResult' but the value was {ToString()}.");

        /// <summary>
        /// Input provided by the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.UserInputStep? UserInput { get; init; }
#else
        public global::Google.Gemini.NextGen.UserInputStep? UserInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInput))]
#endif
        public bool IsUserInput => UserInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.UserInputStep? value)
        {
            value = UserInput;
            return IsUserInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep PickUserInput() => UserInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.CodeExecutionCallStep value) => new Step((global::Google.Gemini.NextGen.CodeExecutionCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecutionCallStep?(Step @this) => @this.CodeExecutionCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.CodeExecutionCallStep? value)
        {
            CodeExecutionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromCodeExecutionCall(global::Google.Gemini.NextGen.CodeExecutionCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.CodeExecutionResultStep value) => new Step((global::Google.Gemini.NextGen.CodeExecutionResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecutionResultStep?(Step @this) => @this.CodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.CodeExecutionResultStep? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromCodeExecutionResult(global::Google.Gemini.NextGen.CodeExecutionResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.FileSearchCallStep value) => new Step((global::Google.Gemini.NextGen.FileSearchCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileSearchCallStep?(Step @this) => @this.FileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.FileSearchCallStep? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromFileSearchCall(global::Google.Gemini.NextGen.FileSearchCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.FileSearchResultStep value) => new Step((global::Google.Gemini.NextGen.FileSearchResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileSearchResultStep?(Step @this) => @this.FileSearchResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.FileSearchResultStep? value)
        {
            FileSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromFileSearchResult(global::Google.Gemini.NextGen.FileSearchResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.FunctionCallStep value) => new Step((global::Google.Gemini.NextGen.FunctionCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FunctionCallStep?(Step @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.FunctionCallStep? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromFunctionCall(global::Google.Gemini.NextGen.FunctionCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.FunctionResultStep value) => new Step((global::Google.Gemini.NextGen.FunctionResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FunctionResultStep?(Step @this) => @this.FunctionResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.FunctionResultStep? value)
        {
            FunctionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromFunctionResult(global::Google.Gemini.NextGen.FunctionResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.GoogleMapsCallStep value) => new Step((global::Google.Gemini.NextGen.GoogleMapsCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleMapsCallStep?(Step @this) => @this.GoogleMapsCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.GoogleMapsCallStep? value)
        {
            GoogleMapsCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromGoogleMapsCall(global::Google.Gemini.NextGen.GoogleMapsCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.GoogleMapsResultStep value) => new Step((global::Google.Gemini.NextGen.GoogleMapsResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleMapsResultStep?(Step @this) => @this.GoogleMapsResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.GoogleMapsResultStep? value)
        {
            GoogleMapsResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromGoogleMapsResult(global::Google.Gemini.NextGen.GoogleMapsResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.GoogleSearchCallStep value) => new Step((global::Google.Gemini.NextGen.GoogleSearchCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearchCallStep?(Step @this) => @this.GoogleSearchCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.GoogleSearchCallStep? value)
        {
            GoogleSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromGoogleSearchCall(global::Google.Gemini.NextGen.GoogleSearchCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.GoogleSearchResultStep value) => new Step((global::Google.Gemini.NextGen.GoogleSearchResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearchResultStep?(Step @this) => @this.GoogleSearchResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.GoogleSearchResultStep? value)
        {
            GoogleSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromGoogleSearchResult(global::Google.Gemini.NextGen.GoogleSearchResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.MCPServerToolCallStep value) => new Step((global::Google.Gemini.NextGen.MCPServerToolCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.MCPServerToolCallStep?(Step @this) => @this.MCPServerToolCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.MCPServerToolCallStep? value)
        {
            MCPServerToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromMCPServerToolCall(global::Google.Gemini.NextGen.MCPServerToolCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.MCPServerToolResultStep value) => new Step((global::Google.Gemini.NextGen.MCPServerToolResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.MCPServerToolResultStep?(Step @this) => @this.MCPServerToolResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.MCPServerToolResultStep? value)
        {
            MCPServerToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromMCPServerToolResult(global::Google.Gemini.NextGen.MCPServerToolResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.ModelOutputStep value) => new Step((global::Google.Gemini.NextGen.ModelOutputStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ModelOutputStep?(Step @this) => @this.ModelOutput;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.ModelOutputStep? value)
        {
            ModelOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromModelOutput(global::Google.Gemini.NextGen.ModelOutputStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.ProcessingCallStep value) => new Step((global::Google.Gemini.NextGen.ProcessingCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ProcessingCallStep?(Step @this) => @this.ProcessingCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.ProcessingCallStep? value)
        {
            ProcessingCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromProcessingCall(global::Google.Gemini.NextGen.ProcessingCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.ProcessingResultStep value) => new Step((global::Google.Gemini.NextGen.ProcessingResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ProcessingResultStep?(Step @this) => @this.ProcessingResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.ProcessingResultStep? value)
        {
            ProcessingResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromProcessingResult(global::Google.Gemini.NextGen.ProcessingResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.RetrievalCallStep value) => new Step((global::Google.Gemini.NextGen.RetrievalCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.RetrievalCallStep?(Step @this) => @this.RetrievalCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.RetrievalCallStep? value)
        {
            RetrievalCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromRetrievalCall(global::Google.Gemini.NextGen.RetrievalCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.RetrievalResultStep value) => new Step((global::Google.Gemini.NextGen.RetrievalResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.RetrievalResultStep?(Step @this) => @this.RetrievalResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.RetrievalResultStep? value)
        {
            RetrievalResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromRetrievalResult(global::Google.Gemini.NextGen.RetrievalResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.ThoughtStep value) => new Step((global::Google.Gemini.NextGen.ThoughtStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ThoughtStep?(Step @this) => @this.Thought;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.ThoughtStep? value)
        {
            Thought = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromThought(global::Google.Gemini.NextGen.ThoughtStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.URLContextCallStep value) => new Step((global::Google.Gemini.NextGen.URLContextCallStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContextCallStep?(Step @this) => @this.URLContextCall;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.URLContextCallStep? value)
        {
            URLContextCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromURLContextCall(global::Google.Gemini.NextGen.URLContextCallStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.URLContextResultStep value) => new Step((global::Google.Gemini.NextGen.URLContextResultStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContextResultStep?(Step @this) => @this.URLContextResult;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.URLContextResultStep? value)
        {
            URLContextResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromURLContextResult(global::Google.Gemini.NextGen.URLContextResultStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Step(global::Google.Gemini.NextGen.UserInputStep value) => new Step((global::Google.Gemini.NextGen.UserInputStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.UserInputStep?(Step @this) => @this.UserInput;

        /// <summary>
        ///
        /// </summary>
        public Step(global::Google.Gemini.NextGen.UserInputStep? value)
        {
            UserInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Step FromUserInput(global::Google.Gemini.NextGen.UserInputStep? value) => new Step(value);

        /// <summary>
        ///
        /// </summary>
        public Step(
            global::Google.Gemini.NextGen.CodeExecutionCallStep? codeExecutionCall,
            global::Google.Gemini.NextGen.CodeExecutionResultStep? codeExecutionResult,
            global::Google.Gemini.NextGen.FileSearchCallStep? fileSearchCall,
            global::Google.Gemini.NextGen.FileSearchResultStep? fileSearchResult,
            global::Google.Gemini.NextGen.FunctionCallStep? functionCall,
            global::Google.Gemini.NextGen.FunctionResultStep? functionResult,
            global::Google.Gemini.NextGen.GoogleMapsCallStep? googleMapsCall,
            global::Google.Gemini.NextGen.GoogleMapsResultStep? googleMapsResult,
            global::Google.Gemini.NextGen.GoogleSearchCallStep? googleSearchCall,
            global::Google.Gemini.NextGen.GoogleSearchResultStep? googleSearchResult,
            global::Google.Gemini.NextGen.MCPServerToolCallStep? mCPServerToolCall,
            global::Google.Gemini.NextGen.MCPServerToolResultStep? mCPServerToolResult,
            global::Google.Gemini.NextGen.ModelOutputStep? modelOutput,
            global::Google.Gemini.NextGen.ProcessingCallStep? processingCall,
            global::Google.Gemini.NextGen.ProcessingResultStep? processingResult,
            global::Google.Gemini.NextGen.RetrievalCallStep? retrievalCall,
            global::Google.Gemini.NextGen.RetrievalResultStep? retrievalResult,
            global::Google.Gemini.NextGen.ThoughtStep? thought,
            global::Google.Gemini.NextGen.URLContextCallStep? uRLContextCall,
            global::Google.Gemini.NextGen.URLContextResultStep? uRLContextResult,
            global::Google.Gemini.NextGen.UserInputStep? userInput
            )
        {
            CodeExecutionCall = codeExecutionCall;
            CodeExecutionResult = codeExecutionResult;
            FileSearchCall = fileSearchCall;
            FileSearchResult = fileSearchResult;
            FunctionCall = functionCall;
            FunctionResult = functionResult;
            GoogleMapsCall = googleMapsCall;
            GoogleMapsResult = googleMapsResult;
            GoogleSearchCall = googleSearchCall;
            GoogleSearchResult = googleSearchResult;
            MCPServerToolCall = mCPServerToolCall;
            MCPServerToolResult = mCPServerToolResult;
            ModelOutput = modelOutput;
            ProcessingCall = processingCall;
            ProcessingResult = processingResult;
            RetrievalCall = retrievalCall;
            RetrievalResult = retrievalResult;
            Thought = thought;
            URLContextCall = uRLContextCall;
            URLContextResult = uRLContextResult;
            UserInput = userInput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UserInput as object ??
            URLContextResult as object ??
            URLContextCall as object ??
            Thought as object ??
            RetrievalResult as object ??
            RetrievalCall as object ??
            ProcessingResult as object ??
            ProcessingCall as object ??
            ModelOutput as object ??
            MCPServerToolResult as object ??
            MCPServerToolCall as object ??
            GoogleSearchResult as object ??
            GoogleSearchCall as object ??
            GoogleMapsResult as object ??
            GoogleMapsCall as object ??
            FunctionResult as object ??
            FunctionCall as object ??
            FileSearchResult as object ??
            FileSearchCall as object ??
            CodeExecutionResult as object ??
            CodeExecutionCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CodeExecutionCall?.ToString() ??
            CodeExecutionResult?.ToString() ??
            FileSearchCall?.ToString() ??
            FileSearchResult?.ToString() ??
            FunctionCall?.ToString() ??
            FunctionResult?.ToString() ??
            GoogleMapsCall?.ToString() ??
            GoogleMapsResult?.ToString() ??
            GoogleSearchCall?.ToString() ??
            GoogleSearchResult?.ToString() ??
            MCPServerToolCall?.ToString() ??
            MCPServerToolResult?.ToString() ??
            ModelOutput?.ToString() ??
            ProcessingCall?.ToString() ??
            ProcessingResult?.ToString() ??
            RetrievalCall?.ToString() ??
            RetrievalResult?.ToString() ??
            Thought?.ToString() ??
            URLContextCall?.ToString() ??
            URLContextResult?.ToString() ??
            UserInput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && IsThought && !IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && IsURLContextCall && !IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && IsURLContextResult && !IsUserInput || !IsCodeExecutionCall && !IsCodeExecutionResult && !IsFileSearchCall && !IsFileSearchResult && !IsFunctionCall && !IsFunctionResult && !IsGoogleMapsCall && !IsGoogleMapsResult && !IsGoogleSearchCall && !IsGoogleSearchResult && !IsMCPServerToolCall && !IsMCPServerToolResult && !IsModelOutput && !IsProcessingCall && !IsProcessingResult && !IsRetrievalCall && !IsRetrievalResult && !IsThought && !IsURLContextCall && !IsURLContextResult && IsUserInput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.CodeExecutionCallStep, TResult>? codeExecutionCall = null,
            global::System.Func<global::Google.Gemini.NextGen.CodeExecutionResultStep, TResult>? codeExecutionResult = null,
            global::System.Func<global::Google.Gemini.NextGen.FileSearchCallStep, TResult>? fileSearchCall = null,
            global::System.Func<global::Google.Gemini.NextGen.FileSearchResultStep, TResult>? fileSearchResult = null,
            global::System.Func<global::Google.Gemini.NextGen.FunctionCallStep, TResult>? functionCall = null,
            global::System.Func<global::Google.Gemini.NextGen.FunctionResultStep, TResult>? functionResult = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleMapsCallStep, TResult>? googleMapsCall = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleMapsResultStep, TResult>? googleMapsResult = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearchCallStep, TResult>? googleSearchCall = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearchResultStep, TResult>? googleSearchResult = null,
            global::System.Func<global::Google.Gemini.NextGen.MCPServerToolCallStep, TResult>? mCPServerToolCall = null,
            global::System.Func<global::Google.Gemini.NextGen.MCPServerToolResultStep, TResult>? mCPServerToolResult = null,
            global::System.Func<global::Google.Gemini.NextGen.ModelOutputStep, TResult>? modelOutput = null,
            global::System.Func<global::Google.Gemini.NextGen.ProcessingCallStep, TResult>? processingCall = null,
            global::System.Func<global::Google.Gemini.NextGen.ProcessingResultStep, TResult>? processingResult = null,
            global::System.Func<global::Google.Gemini.NextGen.RetrievalCallStep, TResult>? retrievalCall = null,
            global::System.Func<global::Google.Gemini.NextGen.RetrievalResultStep, TResult>? retrievalResult = null,
            global::System.Func<global::Google.Gemini.NextGen.ThoughtStep, TResult>? thought = null,
            global::System.Func<global::Google.Gemini.NextGen.URLContextCallStep, TResult>? uRLContextCall = null,
            global::System.Func<global::Google.Gemini.NextGen.URLContextResultStep, TResult>? uRLContextResult = null,
            global::System.Func<global::Google.Gemini.NextGen.UserInputStep, TResult>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionCall is { } __value0 && codeExecutionCall != null)
            {
                return codeExecutionCall(__value0);
            }
            else if (CodeExecutionResult is { } __value1 && codeExecutionResult != null)
            {
                return codeExecutionResult(__value1);
            }
            else if (FileSearchCall is { } __value2 && fileSearchCall != null)
            {
                return fileSearchCall(__value2);
            }
            else if (FileSearchResult is { } __value3 && fileSearchResult != null)
            {
                return fileSearchResult(__value3);
            }
            else if (FunctionCall is { } __value4 && functionCall != null)
            {
                return functionCall(__value4);
            }
            else if (FunctionResult is { } __value5 && functionResult != null)
            {
                return functionResult(__value5);
            }
            else if (GoogleMapsCall is { } __value6 && googleMapsCall != null)
            {
                return googleMapsCall(__value6);
            }
            else if (GoogleMapsResult is { } __value7 && googleMapsResult != null)
            {
                return googleMapsResult(__value7);
            }
            else if (GoogleSearchCall is { } __value8 && googleSearchCall != null)
            {
                return googleSearchCall(__value8);
            }
            else if (GoogleSearchResult is { } __value9 && googleSearchResult != null)
            {
                return googleSearchResult(__value9);
            }
            else if (MCPServerToolCall is { } __value10 && mCPServerToolCall != null)
            {
                return mCPServerToolCall(__value10);
            }
            else if (MCPServerToolResult is { } __value11 && mCPServerToolResult != null)
            {
                return mCPServerToolResult(__value11);
            }
            else if (ModelOutput is { } __value12 && modelOutput != null)
            {
                return modelOutput(__value12);
            }
            else if (ProcessingCall is { } __value13 && processingCall != null)
            {
                return processingCall(__value13);
            }
            else if (ProcessingResult is { } __value14 && processingResult != null)
            {
                return processingResult(__value14);
            }
            else if (RetrievalCall is { } __value15 && retrievalCall != null)
            {
                return retrievalCall(__value15);
            }
            else if (RetrievalResult is { } __value16 && retrievalResult != null)
            {
                return retrievalResult(__value16);
            }
            else if (Thought is { } __value17 && thought != null)
            {
                return thought(__value17);
            }
            else if (URLContextCall is { } __value18 && uRLContextCall != null)
            {
                return uRLContextCall(__value18);
            }
            else if (URLContextResult is { } __value19 && uRLContextResult != null)
            {
                return uRLContextResult(__value19);
            }
            else if (UserInput is { } __value20 && userInput != null)
            {
                return userInput(__value20);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionCallStep>? codeExecutionCall = null,

            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionResultStep>? codeExecutionResult = null,

            global::System.Action<global::Google.Gemini.NextGen.FileSearchCallStep>? fileSearchCall = null,

            global::System.Action<global::Google.Gemini.NextGen.FileSearchResultStep>? fileSearchResult = null,

            global::System.Action<global::Google.Gemini.NextGen.FunctionCallStep>? functionCall = null,

            global::System.Action<global::Google.Gemini.NextGen.FunctionResultStep>? functionResult = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsCallStep>? googleMapsCall = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsResultStep>? googleMapsResult = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchCallStep>? googleSearchCall = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchResultStep>? googleSearchResult = null,

            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolCallStep>? mCPServerToolCall = null,

            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolResultStep>? mCPServerToolResult = null,

            global::System.Action<global::Google.Gemini.NextGen.ModelOutputStep>? modelOutput = null,

            global::System.Action<global::Google.Gemini.NextGen.ProcessingCallStep>? processingCall = null,

            global::System.Action<global::Google.Gemini.NextGen.ProcessingResultStep>? processingResult = null,

            global::System.Action<global::Google.Gemini.NextGen.RetrievalCallStep>? retrievalCall = null,

            global::System.Action<global::Google.Gemini.NextGen.RetrievalResultStep>? retrievalResult = null,

            global::System.Action<global::Google.Gemini.NextGen.ThoughtStep>? thought = null,

            global::System.Action<global::Google.Gemini.NextGen.URLContextCallStep>? uRLContextCall = null,

            global::System.Action<global::Google.Gemini.NextGen.URLContextResultStep>? uRLContextResult = null,

            global::System.Action<global::Google.Gemini.NextGen.UserInputStep>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionCall is { } __value0)
            {
                codeExecutionCall?.Invoke(__value0);
            }
            else if (CodeExecutionResult is { } __value1)
            {
                codeExecutionResult?.Invoke(__value1);
            }
            else if (FileSearchCall is { } __value2)
            {
                fileSearchCall?.Invoke(__value2);
            }
            else if (FileSearchResult is { } __value3)
            {
                fileSearchResult?.Invoke(__value3);
            }
            else if (FunctionCall is { } __value4)
            {
                functionCall?.Invoke(__value4);
            }
            else if (FunctionResult is { } __value5)
            {
                functionResult?.Invoke(__value5);
            }
            else if (GoogleMapsCall is { } __value6)
            {
                googleMapsCall?.Invoke(__value6);
            }
            else if (GoogleMapsResult is { } __value7)
            {
                googleMapsResult?.Invoke(__value7);
            }
            else if (GoogleSearchCall is { } __value8)
            {
                googleSearchCall?.Invoke(__value8);
            }
            else if (GoogleSearchResult is { } __value9)
            {
                googleSearchResult?.Invoke(__value9);
            }
            else if (MCPServerToolCall is { } __value10)
            {
                mCPServerToolCall?.Invoke(__value10);
            }
            else if (MCPServerToolResult is { } __value11)
            {
                mCPServerToolResult?.Invoke(__value11);
            }
            else if (ModelOutput is { } __value12)
            {
                modelOutput?.Invoke(__value12);
            }
            else if (ProcessingCall is { } __value13)
            {
                processingCall?.Invoke(__value13);
            }
            else if (ProcessingResult is { } __value14)
            {
                processingResult?.Invoke(__value14);
            }
            else if (RetrievalCall is { } __value15)
            {
                retrievalCall?.Invoke(__value15);
            }
            else if (RetrievalResult is { } __value16)
            {
                retrievalResult?.Invoke(__value16);
            }
            else if (Thought is { } __value17)
            {
                thought?.Invoke(__value17);
            }
            else if (URLContextCall is { } __value18)
            {
                uRLContextCall?.Invoke(__value18);
            }
            else if (URLContextResult is { } __value19)
            {
                uRLContextResult?.Invoke(__value19);
            }
            else if (UserInput is { } __value20)
            {
                userInput?.Invoke(__value20);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionCallStep>? codeExecutionCall = null,
            global::System.Action<global::Google.Gemini.NextGen.CodeExecutionResultStep>? codeExecutionResult = null,
            global::System.Action<global::Google.Gemini.NextGen.FileSearchCallStep>? fileSearchCall = null,
            global::System.Action<global::Google.Gemini.NextGen.FileSearchResultStep>? fileSearchResult = null,
            global::System.Action<global::Google.Gemini.NextGen.FunctionCallStep>? functionCall = null,
            global::System.Action<global::Google.Gemini.NextGen.FunctionResultStep>? functionResult = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsCallStep>? googleMapsCall = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleMapsResultStep>? googleMapsResult = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchCallStep>? googleSearchCall = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearchResultStep>? googleSearchResult = null,
            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolCallStep>? mCPServerToolCall = null,
            global::System.Action<global::Google.Gemini.NextGen.MCPServerToolResultStep>? mCPServerToolResult = null,
            global::System.Action<global::Google.Gemini.NextGen.ModelOutputStep>? modelOutput = null,
            global::System.Action<global::Google.Gemini.NextGen.ProcessingCallStep>? processingCall = null,
            global::System.Action<global::Google.Gemini.NextGen.ProcessingResultStep>? processingResult = null,
            global::System.Action<global::Google.Gemini.NextGen.RetrievalCallStep>? retrievalCall = null,
            global::System.Action<global::Google.Gemini.NextGen.RetrievalResultStep>? retrievalResult = null,
            global::System.Action<global::Google.Gemini.NextGen.ThoughtStep>? thought = null,
            global::System.Action<global::Google.Gemini.NextGen.URLContextCallStep>? uRLContextCall = null,
            global::System.Action<global::Google.Gemini.NextGen.URLContextResultStep>? uRLContextResult = null,
            global::System.Action<global::Google.Gemini.NextGen.UserInputStep>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionCall is { } __value0)
            {
                codeExecutionCall?.Invoke(__value0);
            }
            else if (CodeExecutionResult is { } __value1)
            {
                codeExecutionResult?.Invoke(__value1);
            }
            else if (FileSearchCall is { } __value2)
            {
                fileSearchCall?.Invoke(__value2);
            }
            else if (FileSearchResult is { } __value3)
            {
                fileSearchResult?.Invoke(__value3);
            }
            else if (FunctionCall is { } __value4)
            {
                functionCall?.Invoke(__value4);
            }
            else if (FunctionResult is { } __value5)
            {
                functionResult?.Invoke(__value5);
            }
            else if (GoogleMapsCall is { } __value6)
            {
                googleMapsCall?.Invoke(__value6);
            }
            else if (GoogleMapsResult is { } __value7)
            {
                googleMapsResult?.Invoke(__value7);
            }
            else if (GoogleSearchCall is { } __value8)
            {
                googleSearchCall?.Invoke(__value8);
            }
            else if (GoogleSearchResult is { } __value9)
            {
                googleSearchResult?.Invoke(__value9);
            }
            else if (MCPServerToolCall is { } __value10)
            {
                mCPServerToolCall?.Invoke(__value10);
            }
            else if (MCPServerToolResult is { } __value11)
            {
                mCPServerToolResult?.Invoke(__value11);
            }
            else if (ModelOutput is { } __value12)
            {
                modelOutput?.Invoke(__value12);
            }
            else if (ProcessingCall is { } __value13)
            {
                processingCall?.Invoke(__value13);
            }
            else if (ProcessingResult is { } __value14)
            {
                processingResult?.Invoke(__value14);
            }
            else if (RetrievalCall is { } __value15)
            {
                retrievalCall?.Invoke(__value15);
            }
            else if (RetrievalResult is { } __value16)
            {
                retrievalResult?.Invoke(__value16);
            }
            else if (Thought is { } __value17)
            {
                thought?.Invoke(__value17);
            }
            else if (URLContextCall is { } __value18)
            {
                uRLContextCall?.Invoke(__value18);
            }
            else if (URLContextResult is { } __value19)
            {
                uRLContextResult?.Invoke(__value19);
            }
            else if (UserInput is { } __value20)
            {
                userInput?.Invoke(__value20);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecutionCall,
                typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep),
                CodeExecutionResult,
                typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep),
                FileSearchCall,
                typeof(global::Google.Gemini.NextGen.FileSearchCallStep),
                FileSearchResult,
                typeof(global::Google.Gemini.NextGen.FileSearchResultStep),
                FunctionCall,
                typeof(global::Google.Gemini.NextGen.FunctionCallStep),
                FunctionResult,
                typeof(global::Google.Gemini.NextGen.FunctionResultStep),
                GoogleMapsCall,
                typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep),
                GoogleMapsResult,
                typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep),
                GoogleSearchCall,
                typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep),
                GoogleSearchResult,
                typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep),
                MCPServerToolCall,
                typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep),
                MCPServerToolResult,
                typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep),
                ModelOutput,
                typeof(global::Google.Gemini.NextGen.ModelOutputStep),
                ProcessingCall,
                typeof(global::Google.Gemini.NextGen.ProcessingCallStep),
                ProcessingResult,
                typeof(global::Google.Gemini.NextGen.ProcessingResultStep),
                RetrievalCall,
                typeof(global::Google.Gemini.NextGen.RetrievalCallStep),
                RetrievalResult,
                typeof(global::Google.Gemini.NextGen.RetrievalResultStep),
                Thought,
                typeof(global::Google.Gemini.NextGen.ThoughtStep),
                URLContextCall,
                typeof(global::Google.Gemini.NextGen.URLContextCallStep),
                URLContextResult,
                typeof(global::Google.Gemini.NextGen.URLContextResultStep),
                UserInput,
                typeof(global::Google.Gemini.NextGen.UserInputStep),
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
        public bool Equals(Step other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecutionCallStep?>.Default.Equals(CodeExecutionCall, other.CodeExecutionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecutionResultStep?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileSearchCallStep?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileSearchResultStep?>.Default.Equals(FileSearchResult, other.FileSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FunctionCallStep?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FunctionResultStep?>.Default.Equals(FunctionResult, other.FunctionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleMapsCallStep?>.Default.Equals(GoogleMapsCall, other.GoogleMapsCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleMapsResultStep?>.Default.Equals(GoogleMapsResult, other.GoogleMapsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearchCallStep?>.Default.Equals(GoogleSearchCall, other.GoogleSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearchResultStep?>.Default.Equals(GoogleSearchResult, other.GoogleSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.MCPServerToolCallStep?>.Default.Equals(MCPServerToolCall, other.MCPServerToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.MCPServerToolResultStep?>.Default.Equals(MCPServerToolResult, other.MCPServerToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ModelOutputStep?>.Default.Equals(ModelOutput, other.ModelOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ProcessingCallStep?>.Default.Equals(ProcessingCall, other.ProcessingCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ProcessingResultStep?>.Default.Equals(ProcessingResult, other.ProcessingResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.RetrievalCallStep?>.Default.Equals(RetrievalCall, other.RetrievalCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.RetrievalResultStep?>.Default.Equals(RetrievalResult, other.RetrievalResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ThoughtStep?>.Default.Equals(Thought, other.Thought) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContextCallStep?>.Default.Equals(URLContextCall, other.URLContextCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContextResultStep?>.Default.Equals(URLContextResult, other.URLContextResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.UserInputStep?>.Default.Equals(UserInput, other.UserInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Step obj1, Step obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Step>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Step obj1, Step obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Step o && Equals(o);
        }
    }
}
