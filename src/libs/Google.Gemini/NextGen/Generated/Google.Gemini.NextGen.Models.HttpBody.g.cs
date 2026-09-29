
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for<br/>
    /// payload formats that can't be represented as JSON, such as raw binary or<br/>
    /// an HTML page.<br/>
    /// This message can be used both in streaming and non-streaming API methods in<br/>
    /// the request as well as the response.<br/>
    /// It can be used as a top-level request field, which is convenient if one<br/>
    /// wants to extract parameters from either the URL or HTTP template into the<br/>
    /// request fields and also want access to the raw HTTP body.<br/>
    /// Example:<br/>
    ///     message GetResourceRequest {<br/>
    ///       // A unique request id.<br/>
    ///       string request_id = 1;<br/>
    ///       // The raw HTTP body is bound to this field.<br/>
    ///       google.api.HttpBody http_body = 2;<br/>
    ///     }<br/>
    ///     service ResourceService {<br/>
    ///       rpc GetResource(GetResourceRequest)<br/>
    ///         returns (google.api.HttpBody);<br/>
    ///       rpc UpdateResource(google.api.HttpBody)<br/>
    ///         returns (google.protobuf.Empty);<br/>
    ///     }<br/>
    /// Example with streaming methods:<br/>
    ///     service CaldavService {<br/>
    ///       rpc GetCalendar(stream google.api.HttpBody)<br/>
    ///         returns (stream google.api.HttpBody);<br/>
    ///       rpc UpdateCalendar(stream google.api.HttpBody)<br/>
    ///         returns (stream google.api.HttpBody);<br/>
    ///     }<br/>
    /// Use of this type only changes how the request and response bodies are<br/>
    /// handled, all other features will continue to work unchanged.
    /// </summary>
    public sealed partial class HttpBody
    {
        /// <summary>
        /// The HTTP Content-Type header value specifying the content type of the body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The HTTP request/response body as raw binary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response<br/>
        /// for streaming APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<object>? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBody" /> class.
        /// </summary>
        /// <param name="contentType">
        /// The HTTP Content-Type header value specifying the content type of the body.
        /// </param>
        /// <param name="data">
        /// The HTTP request/response body as raw binary.
        /// </param>
        /// <param name="extensions">
        /// Application specific response metadata. Must be set in the first response<br/>
        /// for streaming APIs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpBody(
            string? contentType,
            byte[]? data,
            global::System.Collections.Generic.IList<object>? extensions)
        {
            this.ContentType = contentType;
            this.Data = data;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpBody" /> class.
        /// </summary>
        public HttpBody()
        {
        }

    }
}