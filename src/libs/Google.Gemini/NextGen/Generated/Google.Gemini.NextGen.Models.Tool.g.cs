#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
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
        /// A tool that can be used by the model to interact with the computer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ComputerUse? ComputerUse { get; init; }
#else
        public global::Google.Gemini.NextGen.ComputerUse? ComputerUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUse))]
#endif
        public bool IsComputerUse => ComputerUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ComputerUse? value)
        {
            value = ComputerUse;
            return IsComputerUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUse PickComputerUse() => ComputerUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUse' but the value was {ToString()}.");

        /// <summary>
        /// A tool that can be used by the model to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileSearch? FileSearch { get; init; }
#else
        public global::Google.Gemini.NextGen.FileSearch? FileSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FileSearch? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearch PickFileSearch() => FileSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

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
        /// A tool that can be used by the model to call Google Maps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.GoogleMaps? GoogleMaps { get; init; }
#else
        public global::Google.Gemini.NextGen.GoogleMaps? GoogleMaps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleMaps))]
#endif
        public bool IsGoogleMaps => GoogleMaps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGoogleMaps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.GoogleMaps? value)
        {
            value = GoogleMaps;
            return IsGoogleMaps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps PickGoogleMaps() => GoogleMaps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleMaps' but the value was {ToString()}.");

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
        public global::Google.Gemini.NextGen.MCPServer? MCPServer { get; init; }
#else
        public global::Google.Gemini.NextGen.MCPServer? MCPServer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPServer))]
#endif
        public bool IsMCPServer => MCPServer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMCPServer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.MCPServer? value)
        {
            value = MCPServer;
            return IsMCPServer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServer PickMCPServer() => MCPServer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPServer' but the value was {ToString()}.");

        /// <summary>
        /// A tool that can be used by the model to retrieve files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.Retrieval? Retrieval { get; init; }
#else
        public global::Google.Gemini.NextGen.Retrieval? Retrieval { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Retrieval))]
#endif
        public bool IsRetrieval => Retrieval != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetrieval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.Retrieval? value)
        {
            value = Retrieval;
            return IsRetrieval;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Retrieval PickRetrieval() => Retrieval is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Retrieval' but the value was {ToString()}.");

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
        public static implicit operator Tool(global::Google.Gemini.NextGen.CodeExecution value) => new Tool((global::Google.Gemini.NextGen.CodeExecution?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeExecution?(Tool @this) => @this.CodeExecution;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.CodeExecution? value)
        {
            CodeExecution = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromCodeExecution(global::Google.Gemini.NextGen.CodeExecution? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.ComputerUse value) => new Tool((global::Google.Gemini.NextGen.ComputerUse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ComputerUse?(Tool @this) => @this.ComputerUse;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.ComputerUse? value)
        {
            ComputerUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromComputerUse(global::Google.Gemini.NextGen.ComputerUse? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.FileSearch value) => new Tool((global::Google.Gemini.NextGen.FileSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileSearch?(Tool @this) => @this.FileSearch;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.FileSearch? value)
        {
            FileSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromFileSearch(global::Google.Gemini.NextGen.FileSearch? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.Function value) => new Tool((global::Google.Gemini.NextGen.Function?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.Function?(Tool @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.Function? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromFunction(global::Google.Gemini.NextGen.Function? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.GoogleMaps value) => new Tool((global::Google.Gemini.NextGen.GoogleMaps?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleMaps?(Tool @this) => @this.GoogleMaps;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.GoogleMaps? value)
        {
            GoogleMaps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromGoogleMaps(global::Google.Gemini.NextGen.GoogleMaps? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.GoogleSearch value) => new Tool((global::Google.Gemini.NextGen.GoogleSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.GoogleSearch?(Tool @this) => @this.GoogleSearch;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.GoogleSearch? value)
        {
            GoogleSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromGoogleSearch(global::Google.Gemini.NextGen.GoogleSearch? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.MCPServer value) => new Tool((global::Google.Gemini.NextGen.MCPServer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.MCPServer?(Tool @this) => @this.MCPServer;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.MCPServer? value)
        {
            MCPServer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromMCPServer(global::Google.Gemini.NextGen.MCPServer? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.Retrieval value) => new Tool((global::Google.Gemini.NextGen.Retrieval?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.Retrieval?(Tool @this) => @this.Retrieval;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.Retrieval? value)
        {
            Retrieval = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromRetrieval(global::Google.Gemini.NextGen.Retrieval? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Google.Gemini.NextGen.URLContext value) => new Tool((global::Google.Gemini.NextGen.URLContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLContext?(Tool @this) => @this.URLContext;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Google.Gemini.NextGen.URLContext? value)
        {
            URLContext = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromURLContext(global::Google.Gemini.NextGen.URLContext? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public Tool(
            global::Google.Gemini.NextGen.CodeExecution? codeExecution,
            global::Google.Gemini.NextGen.ComputerUse? computerUse,
            global::Google.Gemini.NextGen.FileSearch? fileSearch,
            global::Google.Gemini.NextGen.Function? function,
            global::Google.Gemini.NextGen.GoogleMaps? googleMaps,
            global::Google.Gemini.NextGen.GoogleSearch? googleSearch,
            global::Google.Gemini.NextGen.MCPServer? mCPServer,
            global::Google.Gemini.NextGen.Retrieval? retrieval,
            global::Google.Gemini.NextGen.URLContext? uRLContext
            )
        {
            CodeExecution = codeExecution;
            ComputerUse = computerUse;
            FileSearch = fileSearch;
            Function = function;
            GoogleMaps = googleMaps;
            GoogleSearch = googleSearch;
            MCPServer = mCPServer;
            Retrieval = retrieval;
            URLContext = uRLContext;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            URLContext as object ??
            Retrieval as object ??
            MCPServer as object ??
            GoogleSearch as object ??
            GoogleMaps as object ??
            Function as object ??
            FileSearch as object ??
            ComputerUse as object ??
            CodeExecution as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CodeExecution?.ToString() ??
            ComputerUse?.ToString() ??
            FileSearch?.ToString() ??
            Function?.ToString() ??
            GoogleMaps?.ToString() ??
            GoogleSearch?.ToString() ??
            MCPServer?.ToString() ??
            Retrieval?.ToString() ??
            URLContext?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && IsGoogleSearch && !IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && IsMCPServer && !IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && IsRetrieval && !IsURLContext || !IsCodeExecution && !IsComputerUse && !IsFileSearch && !IsFunction && !IsGoogleMaps && !IsGoogleSearch && !IsMCPServer && !IsRetrieval && IsURLContext;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.CodeExecution, TResult>? codeExecution = null,
            global::System.Func<global::Google.Gemini.NextGen.ComputerUse, TResult>? computerUse = null,
            global::System.Func<global::Google.Gemini.NextGen.FileSearch, TResult>? fileSearch = null,
            global::System.Func<global::Google.Gemini.NextGen.Function, TResult>? function = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleMaps, TResult>? googleMaps = null,
            global::System.Func<global::Google.Gemini.NextGen.GoogleSearch, TResult>? googleSearch = null,
            global::System.Func<global::Google.Gemini.NextGen.MCPServer, TResult>? mCPServer = null,
            global::System.Func<global::Google.Gemini.NextGen.Retrieval, TResult>? retrieval = null,
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
            else if (ComputerUse is { } __value1 && computerUse != null)
            {
                return computerUse(__value1);
            }
            else if (FileSearch is { } __value2 && fileSearch != null)
            {
                return fileSearch(__value2);
            }
            else if (Function is { } __value3 && function != null)
            {
                return function(__value3);
            }
            else if (GoogleMaps is { } __value4 && googleMaps != null)
            {
                return googleMaps(__value4);
            }
            else if (GoogleSearch is { } __value5 && googleSearch != null)
            {
                return googleSearch(__value5);
            }
            else if (MCPServer is { } __value6 && mCPServer != null)
            {
                return mCPServer(__value6);
            }
            else if (Retrieval is { } __value7 && retrieval != null)
            {
                return retrieval(__value7);
            }
            else if (URLContext is { } __value8 && uRLContext != null)
            {
                return uRLContext(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecution>? codeExecution = null,

            global::System.Action<global::Google.Gemini.NextGen.ComputerUse>? computerUse = null,

            global::System.Action<global::Google.Gemini.NextGen.FileSearch>? fileSearch = null,

            global::System.Action<global::Google.Gemini.NextGen.Function>? function = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleMaps>? googleMaps = null,

            global::System.Action<global::Google.Gemini.NextGen.GoogleSearch>? googleSearch = null,

            global::System.Action<global::Google.Gemini.NextGen.MCPServer>? mCPServer = null,

            global::System.Action<global::Google.Gemini.NextGen.Retrieval>? retrieval = null,

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
            else if (ComputerUse is { } __value1)
            {
                computerUse?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (Function is { } __value3)
            {
                function?.Invoke(__value3);
            }
            else if (GoogleMaps is { } __value4)
            {
                googleMaps?.Invoke(__value4);
            }
            else if (GoogleSearch is { } __value5)
            {
                googleSearch?.Invoke(__value5);
            }
            else if (MCPServer is { } __value6)
            {
                mCPServer?.Invoke(__value6);
            }
            else if (Retrieval is { } __value7)
            {
                retrieval?.Invoke(__value7);
            }
            else if (URLContext is { } __value8)
            {
                uRLContext?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.CodeExecution>? codeExecution = null,
            global::System.Action<global::Google.Gemini.NextGen.ComputerUse>? computerUse = null,
            global::System.Action<global::Google.Gemini.NextGen.FileSearch>? fileSearch = null,
            global::System.Action<global::Google.Gemini.NextGen.Function>? function = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleMaps>? googleMaps = null,
            global::System.Action<global::Google.Gemini.NextGen.GoogleSearch>? googleSearch = null,
            global::System.Action<global::Google.Gemini.NextGen.MCPServer>? mCPServer = null,
            global::System.Action<global::Google.Gemini.NextGen.Retrieval>? retrieval = null,
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
            else if (ComputerUse is { } __value1)
            {
                computerUse?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (Function is { } __value3)
            {
                function?.Invoke(__value3);
            }
            else if (GoogleMaps is { } __value4)
            {
                googleMaps?.Invoke(__value4);
            }
            else if (GoogleSearch is { } __value5)
            {
                googleSearch?.Invoke(__value5);
            }
            else if (MCPServer is { } __value6)
            {
                mCPServer?.Invoke(__value6);
            }
            else if (Retrieval is { } __value7)
            {
                retrieval?.Invoke(__value7);
            }
            else if (URLContext is { } __value8)
            {
                uRLContext?.Invoke(__value8);
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
                ComputerUse,
                typeof(global::Google.Gemini.NextGen.ComputerUse),
                FileSearch,
                typeof(global::Google.Gemini.NextGen.FileSearch),
                Function,
                typeof(global::Google.Gemini.NextGen.Function),
                GoogleMaps,
                typeof(global::Google.Gemini.NextGen.GoogleMaps),
                GoogleSearch,
                typeof(global::Google.Gemini.NextGen.GoogleSearch),
                MCPServer,
                typeof(global::Google.Gemini.NextGen.MCPServer),
                Retrieval,
                typeof(global::Google.Gemini.NextGen.Retrieval),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeExecution?>.Default.Equals(CodeExecution, other.CodeExecution) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ComputerUse?>.Default.Equals(ComputerUse, other.ComputerUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileSearch?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.Function?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleMaps?>.Default.Equals(GoogleMaps, other.GoogleMaps) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.GoogleSearch?>.Default.Equals(GoogleSearch, other.GoogleSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.MCPServer?>.Default.Equals(MCPServer, other.MCPServer) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.Retrieval?>.Default.Equals(Retrieval, other.Retrieval) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLContext?>.Default.Equals(URLContext, other.URLContext)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
