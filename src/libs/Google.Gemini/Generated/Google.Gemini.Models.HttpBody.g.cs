
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and non-streaming API methods in the request as well as the response. It can be used as a top-level request field, which is convenient if one wants to extract parameters from either the URL or HTTP template into the request fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id. string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public sealed partial class HttpBody
    {
        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<object>? Extensions { get; set; }

        /// <summary>
        /// The HTTP Content-Type header value specifying the content type of the body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The HTTP request/response body as raw binary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBody" /> class.
        /// </summary>
        /// <param name="extensions">
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </param>
        /// <param name="contentType">
        /// The HTTP Content-Type header value specifying the content type of the body.
        /// </param>
        /// <param name="data">
        /// The HTTP request/response body as raw binary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpBody(
            global::System.Collections.Generic.IList<object>? extensions,
            string? contentType,
            byte[]? data)
        {
            this.Extensions = extensions;
            this.ContentType = contentType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBody" /> class.
        /// </summary>
        public HttpBody()
        {
        }

    }
}