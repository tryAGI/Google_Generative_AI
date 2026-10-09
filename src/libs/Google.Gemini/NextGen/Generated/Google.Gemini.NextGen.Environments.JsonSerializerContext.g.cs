
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistCreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork), TypeInfoPropertyName = "CreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowlistEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "OneOfIListDictionaryStringStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Empty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Environment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork), TypeInfoPropertyName = "EnvironmentNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentStatus), TypeInfoPropertyName = "EnvironmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>), TypeInfoPropertyName = "OneOfIListAllowlistEntryEnvironmentNetworkEgressAllowlistAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist), TypeInfoPropertyName = "EnvironmentNetworkEgressAllowlistAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>?), TypeInfoPropertyName = "NullableOneOfEnvironmentNetworkEgressAllowlistCreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?), TypeInfoPropertyName = "NullableCreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>?), TypeInfoPropertyName = "NullableOneOfIListDictionaryStringStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>?), TypeInfoPropertyName = "NullableOneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork?), TypeInfoPropertyName = "NullableEnvironmentNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentStatus?), TypeInfoPropertyName = "NullableEnvironmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>?), TypeInfoPropertyName = "NullableOneOfIListAllowlistEntryEnvironmentNetworkEgressAllowlistAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?), TypeInfoPropertyName = "NullableEnvironmentNetworkEgressAllowlistAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SourceType?), TypeInfoPropertyName = "NullableSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Environment2>))]
    internal sealed partial class EnvironmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnvironmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>());
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
                    typeToConvert == typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentStatus)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentStatus?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.CreateEnvironmentRequestNetworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.CreateEnvironmentRequestNetworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentStatus))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentStatus?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistAllowlistJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistAllowlistNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.SourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.SourceTypeNullableJsonConverter();
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
                    0 => new EnvironmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}