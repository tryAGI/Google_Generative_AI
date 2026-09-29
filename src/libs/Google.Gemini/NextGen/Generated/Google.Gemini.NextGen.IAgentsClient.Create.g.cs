#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Creates a new Agent (Typed version for SDK).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/agents \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "id": "research-assistant-abc123",<br/>
        ///     "base_agent": "antigravity-preview-05-2026",<br/>
        ///     "description": "A helpful research assistant.",<br/>
        ///     "system_instruction": "You are a helpful research assistant.",<br/>
        ///     "base_environment": "remote",<br/>
        ///     "tools": [{"type": "google_search"}]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Agent> CreateAsync(

            global::Google.Gemini.NextGen.Agent request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Agent (Typed version for SDK).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/agents \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "id": "research-assistant-abc123",<br/>
        ///     "base_agent": "antigravity-preview-05-2026",<br/>
        ///     "description": "A helpful research assistant.",<br/>
        ///     "system_instruction": "You are a helpful research assistant.",<br/>
        ///     "base_environment": "remote",<br/>
        ///     "tools": [{"type": "google_search"}]<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Agent>> CreateAsResponseAsync(

            global::Google.Gemini.NextGen.Agent request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Agent (Typed version for SDK).
        /// </summary>
        /// <param name="agentConfig">
        /// Configuration parameters for the agent.
        /// </param>
        /// <param name="baseAgent">
        /// The base agent to extend.
        /// </param>
        /// <param name="baseEnvironment">
        /// The environment configuration for the agent.
        /// </param>
        /// <param name="description">
        /// Agent description for developers to quickly read and understand.
        /// </param>
        /// <param name="id">
        /// The unique identifier for the agent.
        /// </param>
        /// <param name="systemInstruction">
        /// System instruction for the agent.
        /// </param>
        /// <param name="tools">
        /// The tools available to the agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Agent> CreateAsync(
            global::Google.Gemini.NextGen.AntigravityAgentConfig? agentConfig = default,
            string? baseAgent = default,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? baseEnvironment = default,
            string? description = default,
            string? id = default,
            string? systemInstruction = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>? tools = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}