#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The input for the interaction.
    /// </summary>
    public readonly partial struct InteractionsInput : global::System.IEquatable<InteractionsInput>
    {
        /// <summary>
        /// The content of the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.Content? Content { get; init; }
#else
        public global::Google.Gemini.NextGen.Content? Content { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Content))]
#endif
        public bool IsContent => Content != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.Content? value)
        {
            value = Content;
            return IsContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Content PickContent() => Content is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Content' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? StepList { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? StepList { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepList))]
#endif
        public bool IsStepList => StepList != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? value)
        {
            value = StepList;
            return IsStepList;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step> PickStepList() => StepList is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepList' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? ContentList { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? ContentList { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentList))]
#endif
        public bool IsContentList => ContentList != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? value)
        {
            value = ContentList;
            return IsContentList;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content> PickContentList() => ContentList is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentList' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InteractionsInputVariant4 { get; init; }
#else
        public string? InteractionsInputVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InteractionsInputVariant4))]
#endif
        public bool IsInteractionsInputVariant4 => InteractionsInputVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInteractionsInputVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InteractionsInputVariant4;
            return IsInteractionsInputVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickInteractionsInputVariant4() => InteractionsInputVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InteractionsInputVariant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionsInput(global::Google.Gemini.NextGen.Content value) => new InteractionsInput((global::Google.Gemini.NextGen.Content?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.Content?(InteractionsInput @this) => @this.Content;

        /// <summary>
        ///
        /// </summary>
        public InteractionsInput(global::Google.Gemini.NextGen.Content? value)
        {
            Content = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionsInput FromContent(global::Google.Gemini.NextGen.Content? value) => new InteractionsInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionsInput(string value) => new InteractionsInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(InteractionsInput @this) => @this.InteractionsInputVariant4;

        /// <summary>
        ///
        /// </summary>
        public InteractionsInput(string? value)
        {
            InteractionsInputVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionsInput FromInteractionsInputVariant4(string? value) => new InteractionsInput(value);

        /// <summary>
        ///
        /// </summary>
        public InteractionsInput(
            global::Google.Gemini.NextGen.Content? content,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? stepList,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? contentList,
            string? interactionsInputVariant4
            )
        {
            Content = content;
            StepList = stepList;
            ContentList = contentList;
            InteractionsInputVariant4 = interactionsInputVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InteractionsInputVariant4 as object ??
            ContentList as object ??
            StepList as object ??
            Content as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Content?.ToString() ??
            StepList?.ToString() ??
            ContentList?.ToString() ??
            InteractionsInputVariant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContent && !IsStepList && !IsContentList && !IsInteractionsInputVariant4 || !IsContent && IsStepList && !IsContentList && !IsInteractionsInputVariant4 || !IsContent && !IsStepList && IsContentList && !IsInteractionsInputVariant4 || !IsContent && !IsStepList && !IsContentList && IsInteractionsInputVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.Content?, TResult>? content = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>, TResult>? stepList = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>, TResult>? contentList = null,
            global::System.Func<string, TResult>? interactionsInputVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Content is { } __value0 && content != null)
            {
                return content(__value0);
            }
            else if (StepList is { } __value1 && stepList != null)
            {
                return stepList(__value1);
            }
            else if (ContentList is { } __value2 && contentList != null)
            {
                return contentList(__value2);
            }
            else if (InteractionsInputVariant4 is { } __value3 && interactionsInputVariant4 != null)
            {
                return interactionsInputVariant4(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.Content?>? content = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>>? stepList = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>>? contentList = null,

            global::System.Action<string>? interactionsInputVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Content is { } __value0)
            {
                content?.Invoke(__value0);
            }
            else if (StepList is { } __value1)
            {
                stepList?.Invoke(__value1);
            }
            else if (ContentList is { } __value2)
            {
                contentList?.Invoke(__value2);
            }
            else if (InteractionsInputVariant4 is { } __value3)
            {
                interactionsInputVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.Content?>? content = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>>? stepList = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>>? contentList = null,
            global::System.Action<string>? interactionsInputVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Content is { } __value0)
            {
                content?.Invoke(__value0);
            }
            else if (StepList is { } __value1)
            {
                stepList?.Invoke(__value1);
            }
            else if (ContentList is { } __value2)
            {
                contentList?.Invoke(__value2);
            }
            else if (InteractionsInputVariant4 is { } __value3)
            {
                interactionsInputVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Content,
                typeof(global::Google.Gemini.NextGen.Content),
                StepList,
                typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>),
                ContentList,
                typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>),
                InteractionsInputVariant4,
                typeof(string),
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
        public bool Equals(InteractionsInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.Content?>.Default.Equals(Content, other.Content) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>?>.Default.Equals(StepList, other.StepList) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>?>.Default.Equals(ContentList, other.ContentList) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InteractionsInputVariant4, other.InteractionsInputVariant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InteractionsInput obj1, InteractionsInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InteractionsInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InteractionsInput obj1, InteractionsInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InteractionsInput o && Equals(o);
        }
    }
}
