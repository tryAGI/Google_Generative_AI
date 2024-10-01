
#nullable enable

namespace Google.Gemini
{
    public sealed partial class GeminiClient
    {
        /// <inheritdoc cref="GeminiClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Google.Gemini.EndPointAuthorization?)"/>
        public GeminiClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Google.Gemini.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingApiKeyInQuery(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}