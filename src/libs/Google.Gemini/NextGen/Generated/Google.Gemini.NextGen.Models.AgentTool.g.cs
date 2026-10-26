#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that the agent can use.
    /// </summary>
    public readonly partial struct AgentTool : global::System.IEquatable<AgentTool>
    {
        /// <summary>
        /// A tool that can be used by the model to execute code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeExecution? CodeExecution { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeExecution? CodeExecution { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecution))]
#endif
        public bool IsCodeExecution => CodeExecution != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecution(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.CodeExecution? value)
        {
            value = CodeExecution;
            return IsCodeExecution;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecution PickCodeExecution() => CodeExecution is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecution' but the value was {ToString()}.");

        /// <summary>
        /// A tool that can be used by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.Function? Function { get; init; }
#else
        public global::Google.Gemini.NextGen.Function? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.Function? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Function PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A tool that can be used by the model to search Google.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleSearch? GoogleSearch { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleSearch? GoogleSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSearch))]
#endif
        public bool IsGoogleSearch => GoogleSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleSearch? value)
        {
            value = GoogleSearch;
            return IsGoogleSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearch PickGoogleSearch() => GoogleSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSearch' but the value was {ToString()}.");

        /// <summary>
        /// A MCPServer is a server that can be called by the model to perform actions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.McpServer? McpServer { get; init; }
#else
        public global::Google.Gemini.NextGen.McpServer? McpServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServer))]
#endif
        public bool IsMcpServer => McpServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.McpServer? value)
        {
            value = McpServer;
            return IsMcpServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServer PickMcpServer() => McpServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpServer' but the value was {ToString()}.");

        /// <summary>
        /// A tool that can be used by the model to fetch URL context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLContext? URLContext { get; init; }
#else
        public global::Google.Gemini.NextGen.URLContext? URLContext { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(URLContext))]
#endif
        public bool IsURLContext => URLContext != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickURLContext(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.URLContext? value)
        {
            value = URLContext;
            return IsURLContext;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContext PickURLContext() => URLContext is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLContext' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentTool(global::Google.Gemini.NextGen.CodeExecution value) => new AgentTool((global::Google.Gemini.NextGen.CodeExecution?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecution?(AgentTool @this) => @this.CodeExecution;

        /// <summary>
        ///
        /// </summary>
        public AgentTool(global::Google.Gemini.NextGen.CodeExecution? value)
        {
            CodeExecution = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentTool FromCodeExecution(global::Google.Gemini.NextGen.CodeExecution? value) => new AgentTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentTool(global::Google.Gemini.NextGen.Function value) => new AgentTool((global::Google.Gemini.NextGen.Function?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.Function?(AgentTool @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public AgentTool(global::Google.Gemini.NextGen.Function? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentTool FromFunction(global::Google.Gemini.NextGen.Function? value) => new AgentTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentTool(global::Google.Gemini.NextGen.GoogleSearch value) => new AgentTool((global::Google.Gemini.NextGen.GoogleSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearch?(AgentTool @this) => @this.GoogleSearch;

        /// <summary>
        ///
        /// </summary>
        public AgentTool(global::Google.Gemini.NextGen.GoogleSearch? value)
        {
            GoogleSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentTool FromGoogleSearch(global::Google.Gemini.NextGen.GoogleSearch? value) => new AgentTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentTool(global::Google.Gemini.NextGen.McpServer value) => new AgentTool((global::Google.Gemini.NextGen.McpServer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.McpServer?(AgentTool @this) => @this.McpServer;

        /// <summary>
        ///
        /// </summary>
        public AgentTool(global::Google.Gemini.NextGen.McpServer? value)
        {
            McpServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentTool FromMcpServer(global::Google.Gemini.NextGen.McpServer? value) => new AgentTool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentTool(global::Google.Gemini.NextGen.URLContext value) => new AgentTool((global::Google.Gemini.NextGen.URLContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContext?(AgentTool @this) => @this.URLContext;

        /// <summary>
        ///
        /// </summary>
        public AgentTool(global::Google.Gemini.NextGen.URLContext? value)
        {
            URLContext = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentTool FromURLContext(global::Google.Gemini.NextGen.URLContext? value) => new AgentTool(value);

        /// <summary>
        ///
        /// </summary>
        public AgentTool(
            global::Google.Gemini.NextGen.CodeExecution? codeExecution,
            global::Google.Gemini.NextGen.Function? function,
            global::Google.Gemini.NextGen.GoogleSearch? googleSearch,
            global::Google.Gemini.NextGen.McpServer? mcpServer,
            global::Google.Gemini.NextGen.URLContext? uRLContext
            )
        {
            CodeExecution = codeExecution;
            Function = function;
            GoogleSearch = googleSearch;
            McpServer = mcpServer;
            URLContext = uRLContext;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            URLContext as object ??
            McpServer as object ??
            GoogleSearch as object ??
            Function as object ??
            CodeExecution as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CodeExecution?.ToString() ??
            Function?.ToString() ??
            GoogleSearch?.ToString() ??
            McpServer?.ToString() ??
            URLContext?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecution && !IsFunction && !IsGoogleSearch && !IsMcpServer && !IsURLContext || !IsCodeExecution && IsFunction && !IsGoogleSearch && !IsMcpServer && !IsURLContext || !IsCodeExecution && !IsFunction && IsGoogleSearch && !IsMcpServer && !IsURLContext || !IsCodeExecution && !IsFunction && !IsGoogleSearch && IsMcpServer && !IsURLContext || !IsCodeExecution && !IsFunction && !IsGoogleSearch && !IsMcpServer && IsURLContext;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.CodeExecution, TResult>? codeExecution = null,
            global::System.Func<global::Google.Gemini.NextGen.Function, TResult>? function = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearch, TResult>? googleSearch = null,
            global::System.Func<global::Google.Gemini.NextGen.McpServer, TResult>? mcpServer = null,
            global::System.Func<global::Google.Gemini.NextGen.URLContext, TResult>? uRLContext = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecution is { } __value0 && codeExecution != null)
            {
                return codeExecution(__value0);
            }
            else if (Function is { } __value1 && function != null)
            {
                return function(__value1);
            }
            else if (GoogleSearch is { } __value2 && googleSearch != null)
            {
                return googleSearch(__value2);
            }
            else if (McpServer is { } __value3 && mcpServer != null)
            {
                return mcpServer(__value3);
            }
            else if (URLContext is { } __value4 && uRLContext != null)
            {
                return uRLContext(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecution>? codeExecution = null,

            global::System.Action<global::Google.Gemini.NextGen.Function>? function = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearch>? googleSearch = null,

            global::System.Action<global::Google.Gemini.NextGen.McpServer>? mcpServer = null,

            global::System.Action<global::Google.Gemini.NextGen.URLContext>? uRLContext = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecution is { } __value0)
            {
                codeExecution?.Invoke(__value0);
            }
            else if (Function is { } __value1)
            {
                function?.Invoke(__value1);
            }
            else if (GoogleSearch is { } __value2)
            {
                googleSearch?.Invoke(__value2);
            }
            else if (McpServer is { } __value3)
            {
                mcpServer?.Invoke(__value3);
            }
            else if (URLContext is { } __value4)
            {
                uRLContext?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecution>? codeExecution = null,
            global::System.Action<global::Google.Gemini.NextGen.Function>? function = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearch>? googleSearch = null,
            global::System.Action<global::Google.Gemini.NextGen.McpServer>? mcpServer = null,
            global::System.Action<global::Google.Gemini.NextGen.URLContext>? uRLContext = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecution is { } __value0)
            {
                codeExecution?.Invoke(__value0);
            }
            else if (Function is { } __value1)
            {
                function?.Invoke(__value1);
            }
            else if (GoogleSearch is { } __value2)
            {
                googleSearch?.Invoke(__value2);
            }
            else if (McpServer is { } __value3)
            {
                mcpServer?.Invoke(__value3);
            }
            else if (URLContext is { } __value4)
            {
                uRLContext?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecution,
                typeof(global::Google.Gemini.NextGen.CodeExecution),
                Function,
                typeof(global::Google.Gemini.NextGen.Function),
                GoogleSearch,
                typeof(global::Google.Gemini.NextGen.GoogleSearch),
                McpServer,
                typeof(global::Google.Gemini.NextGen.McpServer),
                URLContext,
                typeof(global::Google.Gemini.NextGen.URLContext),
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
        public bool Equals(AgentTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecution?>.Default.Equals(CodeExecution, other.CodeExecution) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.Function?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearch?>.Default.Equals(GoogleSearch, other.GoogleSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.McpServer?>.Default.Equals(McpServer, other.McpServer) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContext?>.Default.Equals(URLContext, other.URLContext)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentTool obj1, AgentTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentTool obj1, AgentTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentTool o && Equals(o);
        }
    }
}
