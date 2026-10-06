
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseModality), TypeInfoPropertyName = "ResponseModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeleteVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCountType), TypeInfoPropertyName = "GroundingToolCountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ModalityTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Pitch), TypeInfoPropertyName = "Pitch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PromptedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ReplicatedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VoiceType), TypeInfoPropertyName = "VoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseModality?), TypeInfoPropertyName = "NullableResponseModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCountType?), TypeInfoPropertyName = "NullableGroundingToolCountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Pitch?), TypeInfoPropertyName = "NullablePitch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VoiceType?), TypeInfoPropertyName = "NullableVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>());
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
                    typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.Pitch)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.Pitch?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VoiceType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.VoiceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GroundingToolCountType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.Pitch))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PitchJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.Pitch?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.PitchNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ResponseModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.ResponseModality?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.ResponseModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VoiceType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.VoiceType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.VoiceTypeNullableJsonConverter();
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
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}