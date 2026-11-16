#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IDecisionsClient
    {
        /// <summary>
        /// Evaluates a batch of structured decision questions against a shared input.<br/>
        /// Each question is answered independently, and the response contains one calibrated answer per question, keyed by the question IDs from the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/decisions \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "gemini-decision-1",<br/>
        ///     "input": "Customer message: Hi, I was charged twice for my monthly subscription this morning. Can you refund the duplicate charge?",<br/>
        ///     "questions": {<br/>
        ///       "needs_billing_refund": {<br/>
        ///         "type": "noul",<br/>
        ///         "instructions": "Determine whether the customer is requesting a billing refund.",<br/>
        ///         "criteria": {<br/>
        ///           "true_description": "The customer explicitly asks for a refund or reversal of a charge.",<br/>
        ///           "false_description": "The customer is asking a general question or reporting a non-billing issue."<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.CreateDecisionResponse> CreateAsync(

            global::Google.Gemini.NextGen.CreateDecisionRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluates a batch of structured decision questions against a shared input.<br/>
        /// Each question is answered independently, and the response contains one calibrated answer per question, keyed by the question IDs from the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/decisions \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "model": "gemini-decision-1",<br/>
        ///     "input": "Customer message: Hi, I was charged twice for my monthly subscription this morning. Can you refund the duplicate charge?",<br/>
        ///     "questions": {<br/>
        ///       "needs_billing_refund": {<br/>
        ///         "type": "noul",<br/>
        ///         "instructions": "Determine whether the customer is requesting a billing refund.",<br/>
        ///         "criteria": {<br/>
        ///           "true_description": "The customer explicitly asks for a refund or reversal of a charge.",<br/>
        ///           "false_description": "The customer is asking a general question or reporting a non-billing issue."<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.CreateDecisionResponse>> CreateAsResponseAsync(

            global::Google.Gemini.NextGen.CreateDecisionRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluates a batch of structured decision questions against a shared input.<br/>
        /// Each question is answered independently, and the response contains one calibrated answer per question, keyed by the question IDs from the request.
        /// </summary>
        /// <param name="model">
        /// Required. The name of the `Model` used for evaluating the decisions.
        /// </param>
        /// <param name="input">
        /// Required. Shared input prefix evaluated once across all decision questions.
        /// </param>
        /// <param name="questions">
        /// Required. The decision questions to evaluate, keyed by caller-defined unique question<br/>
        /// identifiers (at least 1 question).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.CreateDecisionResponse> CreateAsync(
            string model,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string> input,
            global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question> questions,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}