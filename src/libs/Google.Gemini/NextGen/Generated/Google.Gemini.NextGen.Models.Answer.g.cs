#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Decision answer for a single question.
    /// </summary>
    public readonly partial struct Answer : global::System.IEquatable<Answer>
    {
        /// <summary>
        /// Calibrated result for a `ChoiceQuestion`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ChoiceAnswer? Choice { get; init; }
#else
        public global::Google.Gemini.NextGen.ChoiceAnswer? Choice { get; }
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
            out global::Google.Gemini.NextGen.ChoiceAnswer? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ChoiceAnswer PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        /// Calibrated result for a `NoulQuestion`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.NoulAnswer? Noul { get; init; }
#else
        public global::Google.Gemini.NextGen.NoulAnswer? Noul { get; }
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
            out global::Google.Gemini.NextGen.NoulAnswer? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulAnswer PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        /// Calibrated result for a `ScoreQuestion`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ScoreAnswer? Score { get; init; }
#else
        public global::Google.Gemini.NextGen.ScoreAnswer? Score { get; }
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
            out global::Google.Gemini.NextGen.ScoreAnswer? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ScoreAnswer PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answer(global::Google.Gemini.NextGen.ChoiceAnswer value) => new Answer((global::Google.Gemini.NextGen.ChoiceAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ChoiceAnswer?(Answer @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Answer(global::Google.Gemini.NextGen.ChoiceAnswer? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answer FromChoice(global::Google.Gemini.NextGen.ChoiceAnswer? value) => new Answer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answer(global::Google.Gemini.NextGen.NoulAnswer value) => new Answer((global::Google.Gemini.NextGen.NoulAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.NoulAnswer?(Answer @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Answer(global::Google.Gemini.NextGen.NoulAnswer? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answer FromNoul(global::Google.Gemini.NextGen.NoulAnswer? value) => new Answer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answer(global::Google.Gemini.NextGen.ScoreAnswer value) => new Answer((global::Google.Gemini.NextGen.ScoreAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ScoreAnswer?(Answer @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Answer(global::Google.Gemini.NextGen.ScoreAnswer? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answer FromScore(global::Google.Gemini.NextGen.ScoreAnswer? value) => new Answer(value);

        /// <summary>
        ///
        /// </summary>
        public Answer(
            global::Google.Gemini.NextGen.ChoiceAnswer? choice,
            global::Google.Gemini.NextGen.NoulAnswer? noul,
            global::Google.Gemini.NextGen.ScoreAnswer? score
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
            global::System.Func<global::Google.Gemini.NextGen.ChoiceAnswer, TResult>? choice = null,
            global::System.Func<global::Google.Gemini.NextGen.NoulAnswer, TResult>? noul = null,
            global::System.Func<global::Google.Gemini.NextGen.ScoreAnswer, TResult>? score = null,
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
            global::System.Action<global::Google.Gemini.NextGen.ChoiceAnswer>? choice = null,

            global::System.Action<global::Google.Gemini.NextGen.NoulAnswer>? noul = null,

            global::System.Action<global::Google.Gemini.NextGen.ScoreAnswer>? score = null,
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
            global::System.Action<global::Google.Gemini.NextGen.ChoiceAnswer>? choice = null,
            global::System.Action<global::Google.Gemini.NextGen.NoulAnswer>? noul = null,
            global::System.Action<global::Google.Gemini.NextGen.ScoreAnswer>? score = null,
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
                typeof(global::Google.Gemini.NextGen.ChoiceAnswer),
                Noul,
                typeof(global::Google.Gemini.NextGen.NoulAnswer),
                Score,
                typeof(global::Google.Gemini.NextGen.ScoreAnswer),
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
        public bool Equals(Answer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ChoiceAnswer?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.NoulAnswer?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ScoreAnswer?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Answer obj1, Answer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Answer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Answer obj1, Answer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Answer o && Equals(o);
        }
    }
}
