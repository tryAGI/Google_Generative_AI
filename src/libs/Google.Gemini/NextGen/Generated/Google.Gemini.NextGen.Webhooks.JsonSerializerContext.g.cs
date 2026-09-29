
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Empty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PingWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookPingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior), TypeInfoPropertyName = "RotateSigningSecretRequestRevocationBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SigningSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookState), TypeInfoPropertyName = "WebhookState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent), TypeInfoPropertyName = "WebhookSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateState), TypeInfoPropertyName = "WebhookUpdateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent), TypeInfoPropertyName = "WebhookUpdateSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior?), TypeInfoPropertyName = "NullableRotateSigningSecretRequestRevocationBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookState?), TypeInfoPropertyName = "NullableWebhookState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent?), TypeInfoPropertyName = "NullableWebhookSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateState?), TypeInfoPropertyName = "NullableWebhookUpdateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent?), TypeInfoPropertyName = "NullableWebhookUpdateSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>))]
    internal sealed partial class WebhooksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WebhooksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WebhooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookState)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookState?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateState)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateState?)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent)

                    || typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.RotateSigningSecretRequestRevocationBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.RotateSigningSecretRequestRevocationBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookState))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookState?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookSubscribedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookSubscribedEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateState))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateState?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateSubscribedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent?))
                {
                    return new global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateSubscribedEventNullableJsonConverter();
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
                    0 => new WebhooksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}