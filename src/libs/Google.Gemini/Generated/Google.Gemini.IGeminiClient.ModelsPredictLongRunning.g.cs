#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Same as Predict but returns an LRO.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> ModelsPredictLongRunningAsync(
            string modelsId,

            global::Google.Gemini.PredictLongRunningRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Same as Predict but returns an LRO.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// </param>
        /// <param name="parameters">
        /// Optional. The parameters that govern the prediction call.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> ModelsPredictLongRunningAsync(
            string modelsId,
            global::System.Collections.Generic.IList<object>? instances = default,
            object? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}