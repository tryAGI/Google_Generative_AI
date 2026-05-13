
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The function response in JSON object format. Callers can use any keys of their choice that fit the function's syntax to return the function output, e.g. "output", "result", etc. In particular, if the function call failed to execute, the response can have an "error" key to return error details to the model. Multimedia can be included by using a subobject containing a single "$ref" key whose value is the `inline_data.display_name` of a `FunctionResponsePart` holding the multimedia. See https://ai.google.dev/gemini-api/docs/function-calling#multimodal.
    /// </summary>
    public sealed partial class FunctionResponseResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}