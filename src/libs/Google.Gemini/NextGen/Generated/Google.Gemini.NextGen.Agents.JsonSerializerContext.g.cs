
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AntigravityAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>), TypeInfoPropertyName = "OneOfEnvironment3String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Environment3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentTool), TypeInfoPropertyName = "AgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowedTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowedToolsMode), TypeInfoPropertyName = "AllowedToolsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist), TypeInfoPropertyName = "EnvironmentNetworkEgressAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowlistEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "OneOfIListDictionaryStringStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Empty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>), TypeInfoPropertyName = "OneOfDictionaryStringEnvVarString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork2?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2), TypeInfoPropertyName = "EnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2), TypeInfoPropertyName = "EnvironmentNetworkEgressAllowlistEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType), TypeInfoPropertyName = "GoogleSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>?), TypeInfoPropertyName = "NullableOneOfEnvironment3String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentTool?), TypeInfoPropertyName = "NullableAgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowedToolsMode?), TypeInfoPropertyName = "NullableAllowedToolsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?), TypeInfoPropertyName = "NullableEnvironmentNetworkEgressAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>?), TypeInfoPropertyName = "NullableOneOfIListDictionaryStringStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>?), TypeInfoPropertyName = "NullableOneOfDictionaryStringEnvVarString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork2?>?), TypeInfoPropertyName = "NullableOneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2?), TypeInfoPropertyName = "NullableEnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?), TypeInfoPropertyName = "NullableEnvironmentNetworkEgressAllowlistEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType?), TypeInfoPropertyName = "NullableGoogleSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SourceType?), TypeInfoPropertyName = "NullableSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchSearchType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowedTools>))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.AgentToolJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistJsonConverter());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork2?>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>());
            options.Converters.Add(new global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>());
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
                    typeToConvert == typeof(global::Google.Gemini.NextGen.AllowedToolsMode)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.AllowedToolsMode?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.SourceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AllowedToolsMode))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AllowedToolsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.AllowedToolsMode?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.AllowedToolsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetwork2JsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetwork2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistEnum2JsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistEnum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GoogleSearchSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.GoogleSearchSearchTypeNullableJsonConverter();
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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}