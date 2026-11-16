#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A single decision question.
    /// </summary>
    public readonly partial struct Question : global::System.IEquatable<Question>
    {
        /// <summary>
        /// A single-select categorical decision question over mutually exclusive<br/>
        /// options.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ChoiceQuestion? Choice { get; init; }
#else
        public global::Google.Gemini.NextGen.ChoiceQuestion? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ChoiceQuestion? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ChoiceQuestion PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        /// A binary (true / false) decision question.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.NoulQuestion? Noul { get; init; }
#else
        public global::Google.Gemini.NextGen.NoulQuestion? Noul { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Noul))]
#endif
        public bool IsNoul => Noul != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNoul(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.NoulQuestion? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulQuestion PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        /// A quantitative rubric scoring question over discrete numeric levels.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ScoreQuestion? Score { get; init; }
#else
        public global::Google.Gemini.NextGen.ScoreQuestion? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ScoreQuestion? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ScoreQuestion PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Question(global::Google.Gemini.NextGen.ChoiceQuestion value) => new Question((global::Google.Gemini.NextGen.ChoiceQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ChoiceQuestion?(Question @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Question(global::Google.Gemini.NextGen.ChoiceQuestion? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Question FromChoice(global::Google.Gemini.NextGen.ChoiceQuestion? value) => new Question(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Question(global::Google.Gemini.NextGen.NoulQuestion value) => new Question((global::Google.Gemini.NextGen.NoulQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.NoulQuestion?(Question @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Question(global::Google.Gemini.NextGen.NoulQuestion? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Question FromNoul(global::Google.Gemini.NextGen.NoulQuestion? value) => new Question(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Question(global::Google.Gemini.NextGen.ScoreQuestion value) => new Question((global::Google.Gemini.NextGen.ScoreQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ScoreQuestion?(Question @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Question(global::Google.Gemini.NextGen.ScoreQuestion? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Question FromScore(global::Google.Gemini.NextGen.ScoreQuestion? value) => new Question(value);

        /// <summary>
        ///
        /// </summary>
        public Question(
            global::Google.Gemini.NextGen.ChoiceQuestion? choice,
            global::Google.Gemini.NextGen.NoulQuestion? noul,
            global::Google.Gemini.NextGen.ScoreQuestion? score
            )
        {
            Choice = choice;
            Noul = noul;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Noul as object ??
            Choice as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Choice?.ToString() ??
            Noul?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsChoice && !IsNoul && !IsScore || !IsChoice && IsNoul && !IsScore || !IsChoice && !IsNoul && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.ChoiceQuestion, TResult>? choice = null,
            global::System.Func<global::Google.Gemini.NextGen.NoulQuestion, TResult>? noul = null,
            global::System.Func<global::Google.Gemini.NextGen.ScoreQuestion, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0 && choice != null)
            {
                return choice(__value0);
            }
            else if (Noul is { } __value1 && noul != null)
            {
                return noul(__value1);
            }
            else if (Score is { } __value2 && score != null)
            {
                return score(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.ChoiceQuestion>? choice = null,

            global::System.Action<global::Google.Gemini.NextGen.NoulQuestion>? noul = null,

            global::System.Action<global::Google.Gemini.NextGen.ScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Noul is { } __value1)
            {
                noul?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.ChoiceQuestion>? choice = null,
            global::System.Action<global::Google.Gemini.NextGen.NoulQuestion>? noul = null,
            global::System.Action<global::Google.Gemini.NextGen.ScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Choice is { } __value0)
            {
                choice?.Invoke(__value0);
            }
            else if (Noul is { } __value1)
            {
                noul?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Choice,
                typeof(global::Google.Gemini.NextGen.ChoiceQuestion),
                Noul,
                typeof(global::Google.Gemini.NextGen.NoulQuestion),
                Score,
                typeof(global::Google.Gemini.NextGen.ScoreQuestion),
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
        public bool Equals(Question other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ChoiceQuestion?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.NoulQuestion?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ScoreQuestion?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Question obj1, Question obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Question>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Question obj1, Question obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Question o && Equals(o);
        }
    }
}
