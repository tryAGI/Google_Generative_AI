#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen.JsonConverters
{
    /// <inheritdoc />
    public class InteractionSSEEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Google.Gemini.NextGen.InteractionSSEEvent>
    {
        /// <inheritdoc />
        public override global::Google.Gemini.NextGen.InteractionSSEEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("error.code")) __score0++;
            if (__jsonProps.Contains("error.message")) __score0++;
            if (__jsonProps.Contains("event_id")) __score0++;
            if (__jsonProps.Contains("event_type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("event_id")) __score1++;
            if (__jsonProps.Contains("event_type")) __score1++;
            if (__jsonProps.Contains("interaction")) __score1++;
            if (__jsonProps.Contains("interaction.agent")) __score1++;
            if (__jsonProps.Contains("interaction.created")) __score1++;
            if (__jsonProps.Contains("interaction.id")) __score1++;
            if (__jsonProps.Contains("interaction.model")) __score1++;
            if (__jsonProps.Contains("interaction.object")) __score1++;
            if (__jsonProps.Contains("interaction.service_tier")) __score1++;
            if (__jsonProps.Contains("interaction.status")) __score1++;
            if (__jsonProps.Contains("interaction.steps")) __score1++;
            if (__jsonProps.Contains("interaction.updated")) __score1++;
            if (__jsonProps.Contains("interaction.usage")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("event_id")) __score2++;
            if (__jsonProps.Contains("event_type")) __score2++;
            if (__jsonProps.Contains("interaction")) __score2++;
            if (__jsonProps.Contains("interaction.agent")) __score2++;
            if (__jsonProps.Contains("interaction.created")) __score2++;
            if (__jsonProps.Contains("interaction.id")) __score2++;
            if (__jsonProps.Contains("interaction.model")) __score2++;
            if (__jsonProps.Contains("interaction.object")) __score2++;
            if (__jsonProps.Contains("interaction.service_tier")) __score2++;
            if (__jsonProps.Contains("interaction.status")) __score2++;
            if (__jsonProps.Contains("interaction.steps")) __score2++;
            if (__jsonProps.Contains("interaction.updated")) __score2++;
            if (__jsonProps.Contains("interaction.usage")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("event_id")) __score3++;
            if (__jsonProps.Contains("event_type")) __score3++;
            if (__jsonProps.Contains("interaction_id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("event_id")) __score4++;
            if (__jsonProps.Contains("event_type")) __score4++;
            if (__jsonProps.Contains("index")) __score4++;
            if (__jsonProps.Contains("metadata")) __score4++;
            if (__jsonProps.Contains("metadata.total_usage")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("event_id")) __score5++;
            if (__jsonProps.Contains("event_type")) __score5++;
            if (__jsonProps.Contains("index")) __score5++;
            if (__jsonProps.Contains("step")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("event_id")) __score6++;
            if (__jsonProps.Contains("event_type")) __score6++;
            if (__jsonProps.Contains("index")) __score6++;
            if (__jsonProps.Contains("step_usage")) __score6++;
            if (__jsonProps.Contains("step_usage.cached_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("step_usage.grounding_tool_count")) __score6++;
            if (__jsonProps.Contains("step_usage.input_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("step_usage.output_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("step_usage.tool_use_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("step_usage.total_cached_tokens")) __score6++;
            if (__jsonProps.Contains("step_usage.total_input_tokens")) __score6++;
            if (__jsonProps.Contains("step_usage.total_output_tokens")) __score6++;
            if (__jsonProps.Contains("step_usage.total_thought_tokens")) __score6++;
            if (__jsonProps.Contains("step_usage.total_tokens")) __score6++;
            if (__jsonProps.Contains("step_usage.total_tool_use_tokens")) __score6++;
            if (__jsonProps.Contains("usage")) __score6++;
            if (__jsonProps.Contains("usage.cached_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("usage.grounding_tool_count")) __score6++;
            if (__jsonProps.Contains("usage.input_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("usage.output_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("usage.tool_use_tokens_by_modality")) __score6++;
            if (__jsonProps.Contains("usage.total_cached_tokens")) __score6++;
            if (__jsonProps.Contains("usage.total_input_tokens")) __score6++;
            if (__jsonProps.Contains("usage.total_output_tokens")) __score6++;
            if (__jsonProps.Contains("usage.total_thought_tokens")) __score6++;
            if (__jsonProps.Contains("usage.total_tokens")) __score6++;
            if (__jsonProps.Contains("usage.total_tool_use_tokens")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Google.Gemini.NextGen.ErrorEvent? error = default;
            global::Google.Gemini.NextGen.InteractionCompletedEvent? completed = default;
            global::Google.Gemini.NextGen.InteractionCreatedEvent? created = default;
            global::Google.Gemini.NextGen.InteractionStatusUpdate? statusUpdate = default;
            global::Google.Gemini.NextGen.StepDelta? stepDelta = default;
            global::Google.Gemini.NextGen.StepStart? stepStart = default;
            global::Google.Gemini.NextGen.StepStop? stepStop = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ErrorEvent).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCompletedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent).Name}");
                        completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCreatedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent).Name}");
                        created = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionStatusUpdate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate).Name}");
                        statusUpdate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepDelta> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepDelta).Name}");
                        stepDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStart> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStart).Name}");
                        stepStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStop> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStop).Name}");
                        stepStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ErrorEvent).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCompletedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent).Name}");
                    completed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCreatedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent).Name}");
                    created = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionStatusUpdate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate).Name}");
                    statusUpdate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepDelta> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepDelta).Name}");
                    stepDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStart> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStart).Name}");
                    stepStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && completed == null && created == null && statusUpdate == null && stepDelta == null && stepStart == null && stepStop == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStop> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStop).Name}");
                    stepStop = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Google.Gemini.NextGen.InteractionSSEEvent(
                error,

                completed,

                created,

                statusUpdate,

                stepDelta,

                stepStart,

                stepStop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Google.Gemini.NextGen.InteractionSSEEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Created!, typeInfo);
            }
            else if (value.IsStatusUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.InteractionStatusUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StatusUpdate!, typeInfo);
            }
            else if (value.IsStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepDelta!, typeInfo);
            }
            else if (value.IsStepStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStart), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStart?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStart).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepStart!, typeInfo);
            }
            else if (value.IsStepStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Google.Gemini.NextGen.StepStop), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Google.Gemini.NextGen.StepStop?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Google.Gemini.NextGen.StepStop).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepStop!, typeInfo);
            }
        }
    }
}