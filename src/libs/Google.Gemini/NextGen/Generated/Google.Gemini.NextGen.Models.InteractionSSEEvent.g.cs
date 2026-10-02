#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InteractionSSEEvent : global::System.IEquatable<InteractionSSEEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ErrorEvent? Error { get; init; }
#else
        public global::Google.Gemini.NextGen.ErrorEvent? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// Signals that the Interaction completed. Sent when the Interaction receives<br/>
        /// Complete/Cancel or naturally terminates. No more input can be sent to the<br/>
        /// Interaction after this.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Completed { get; init; }
#else
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Completed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.InteractionCompletedEvent? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        /// Server response confirming that a new interaction was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Created { get; init; }
#else
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Created { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Created))]
#endif
        public bool IsCreated => Created != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.InteractionCreatedEvent? value)
        {
            value = Created;
            return IsCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent PickCreated() => Created is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Created' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? StatusUpdate { get; init; }
#else
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? StatusUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StatusUpdate))]
#endif
        public bool IsStatusUpdate => StatusUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStatusUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.InteractionStatusUpdate? value)
        {
            value = StatusUpdate;
            return IsStatusUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate PickStatusUpdate() => StatusUpdate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StatusUpdate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.StepDelta? StepDelta { get; init; }
#else
        public global::Google.Gemini.NextGen.StepDelta? StepDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepDelta))]
#endif
        public bool IsStepDelta => StepDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.StepDelta? value)
        {
            value = StepDelta;
            return IsStepDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta PickStepDelta() => StepDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepDelta' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.StepStart? StepStart { get; init; }
#else
        public global::Google.Gemini.NextGen.StepStart? StepStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepStart))]
#endif
        public bool IsStepStart => StepStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.StepStart? value)
        {
            value = StepStart;
            return IsStepStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart PickStepStart() => StepStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepStart' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.StepStop? StepStop { get; init; }
#else
        public global::Google.Gemini.NextGen.StepStop? StepStop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepStop))]
#endif
        public bool IsStepStop => StepStop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.StepStop? value)
        {
            value = StepStop;
            return IsStepStop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop PickStepStop() => StepStop is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepStop' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.ErrorEvent value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.ErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ErrorEvent?(InteractionSSEEvent @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromError(global::Google.Gemini.NextGen.ErrorEvent? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionCompletedEvent value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.InteractionCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.InteractionCompletedEvent?(InteractionSSEEvent @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionCompletedEvent? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromCompleted(global::Google.Gemini.NextGen.InteractionCompletedEvent? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionCreatedEvent value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.InteractionCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.InteractionCreatedEvent?(InteractionSSEEvent @this) => @this.Created;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionCreatedEvent? value)
        {
            Created = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromCreated(global::Google.Gemini.NextGen.InteractionCreatedEvent? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionStatusUpdate value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.InteractionStatusUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.InteractionStatusUpdate?(InteractionSSEEvent @this) => @this.StatusUpdate;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.InteractionStatusUpdate? value)
        {
            StatusUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromStatusUpdate(global::Google.Gemini.NextGen.InteractionStatusUpdate? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.StepDelta value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.StepDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.StepDelta?(InteractionSSEEvent @this) => @this.StepDelta;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.StepDelta? value)
        {
            StepDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromStepDelta(global::Google.Gemini.NextGen.StepDelta? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.StepStart value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.StepStart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.StepStart?(InteractionSSEEvent @this) => @this.StepStart;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.StepStart? value)
        {
            StepStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromStepStart(global::Google.Gemini.NextGen.StepStart? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InteractionSSEEvent(global::Google.Gemini.NextGen.StepStop value) => new InteractionSSEEvent((global::Google.Gemini.NextGen.StepStop?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.StepStop?(InteractionSSEEvent @this) => @this.StepStop;

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(global::Google.Gemini.NextGen.StepStop? value)
        {
            StepStop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InteractionSSEEvent FromStepStop(global::Google.Gemini.NextGen.StepStop? value) => new InteractionSSEEvent(value);

        /// <summary>
        ///
        /// </summary>
        public InteractionSSEEvent(
            global::Google.Gemini.NextGen.ErrorEvent? error,
            global::Google.Gemini.NextGen.InteractionCompletedEvent? completed,
            global::Google.Gemini.NextGen.InteractionCreatedEvent? created,
            global::Google.Gemini.NextGen.InteractionStatusUpdate? statusUpdate,
            global::Google.Gemini.NextGen.StepDelta? stepDelta,
            global::Google.Gemini.NextGen.StepStart? stepStart,
            global::Google.Gemini.NextGen.StepStop? stepStop
            )
        {
            Error = error;
            Completed = completed;
            Created = created;
            StatusUpdate = statusUpdate;
            StepDelta = stepDelta;
            StepStart = stepStart;
            StepStop = stepStop;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepStop as object ??
            StepStart as object ??
            StepDelta as object ??
            StatusUpdate as object ??
            Created as object ??
            Completed as object ??
            Error as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            Completed?.ToString() ??
            Created?.ToString() ??
            StatusUpdate?.ToString() ??
            StepDelta?.ToString() ??
            StepStart?.ToString() ??
            StepStop?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsError && !IsCompleted && !IsCreated && !IsStatusUpdate && !IsStepDelta && !IsStepStart && !IsStepStop || !IsError && IsCompleted && !IsCreated && !IsStatusUpdate && !IsStepDelta && !IsStepStart && !IsStepStop || !IsError && !IsCompleted && IsCreated && !IsStatusUpdate && !IsStepDelta && !IsStepStart && !IsStepStop || !IsError && !IsCompleted && !IsCreated && IsStatusUpdate && !IsStepDelta && !IsStepStart && !IsStepStop || !IsError && !IsCompleted && !IsCreated && !IsStatusUpdate && IsStepDelta && !IsStepStart && !IsStepStop || !IsError && !IsCompleted && !IsCreated && !IsStatusUpdate && !IsStepDelta && IsStepStart && !IsStepStop || !IsError && !IsCompleted && !IsCreated && !IsStatusUpdate && !IsStepDelta && !IsStepStart && IsStepStop;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.ErrorEvent, TResult>? error = null,
            global::System.Func<global::Google.Gemini.NextGen.InteractionCompletedEvent, TResult>? completed = null,
            global::System.Func<global::Google.Gemini.NextGen.InteractionCreatedEvent, TResult>? created = null,
            global::System.Func<global::Google.Gemini.NextGen.InteractionStatusUpdate, TResult>? statusUpdate = null,
            global::System.Func<global::Google.Gemini.NextGen.StepDelta, TResult>? stepDelta = null,
            global::System.Func<global::Google.Gemini.NextGen.StepStart, TResult>? stepStart = null,
            global::System.Func<global::Google.Gemini.NextGen.StepStop, TResult>? stepStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0 && error != null)
            {
                return error(__value0);
            }
            else if (Completed is { } __value1 && completed != null)
            {
                return completed(__value1);
            }
            else if (Created is { } __value2 && created != null)
            {
                return created(__value2);
            }
            else if (StatusUpdate is { } __value3 && statusUpdate != null)
            {
                return statusUpdate(__value3);
            }
            else if (StepDelta is { } __value4 && stepDelta != null)
            {
                return stepDelta(__value4);
            }
            else if (StepStart is { } __value5 && stepStart != null)
            {
                return stepStart(__value5);
            }
            else if (StepStop is { } __value6 && stepStop != null)
            {
                return stepStop(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.ErrorEvent>? error = null,

            global::System.Action<global::Google.Gemini.NextGen.InteractionCompletedEvent>? completed = null,

            global::System.Action<global::Google.Gemini.NextGen.InteractionCreatedEvent>? created = null,

            global::System.Action<global::Google.Gemini.NextGen.InteractionStatusUpdate>? statusUpdate = null,

            global::System.Action<global::Google.Gemini.NextGen.StepDelta>? stepDelta = null,

            global::System.Action<global::Google.Gemini.NextGen.StepStart>? stepStart = null,

            global::System.Action<global::Google.Gemini.NextGen.StepStop>? stepStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (Completed is { } __value1)
            {
                completed?.Invoke(__value1);
            }
            else if (Created is { } __value2)
            {
                created?.Invoke(__value2);
            }
            else if (StatusUpdate is { } __value3)
            {
                statusUpdate?.Invoke(__value3);
            }
            else if (StepDelta is { } __value4)
            {
                stepDelta?.Invoke(__value4);
            }
            else if (StepStart is { } __value5)
            {
                stepStart?.Invoke(__value5);
            }
            else if (StepStop is { } __value6)
            {
                stepStop?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.ErrorEvent>? error = null,
            global::System.Action<global::Google.Gemini.NextGen.InteractionCompletedEvent>? completed = null,
            global::System.Action<global::Google.Gemini.NextGen.InteractionCreatedEvent>? created = null,
            global::System.Action<global::Google.Gemini.NextGen.InteractionStatusUpdate>? statusUpdate = null,
            global::System.Action<global::Google.Gemini.NextGen.StepDelta>? stepDelta = null,
            global::System.Action<global::Google.Gemini.NextGen.StepStart>? stepStart = null,
            global::System.Action<global::Google.Gemini.NextGen.StepStop>? stepStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (Completed is { } __value1)
            {
                completed?.Invoke(__value1);
            }
            else if (Created is { } __value2)
            {
                created?.Invoke(__value2);
            }
            else if (StatusUpdate is { } __value3)
            {
                statusUpdate?.Invoke(__value3);
            }
            else if (StepDelta is { } __value4)
            {
                stepDelta?.Invoke(__value4);
            }
            else if (StepStart is { } __value5)
            {
                stepStart?.Invoke(__value5);
            }
            else if (StepStop is { } __value6)
            {
                stepStop?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::Google.Gemini.NextGen.ErrorEvent),
                Completed,
                typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent),
                Created,
                typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent),
                StatusUpdate,
                typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate),
                StepDelta,
                typeof(global::Google.Gemini.NextGen.StepDelta),
                StepStart,
                typeof(global::Google.Gemini.NextGen.StepStart),
                StepStop,
                typeof(global::Google.Gemini.NextGen.StepStop),
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
        public bool Equals(InteractionSSEEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.InteractionCompletedEvent?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.InteractionCreatedEvent?>.Default.Equals(Created, other.Created) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.InteractionStatusUpdate?>.Default.Equals(StatusUpdate, other.StatusUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.StepDelta?>.Default.Equals(StepDelta, other.StepDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.StepStart?>.Default.Equals(StepStart, other.StepStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.StepStop?>.Default.Equals(StepStop, other.StepStop)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InteractionSSEEvent obj1, InteractionSSEEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InteractionSSEEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InteractionSSEEvent obj1, InteractionSSEEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InteractionSSEEvent o && Equals(o);
        }
    }
}
