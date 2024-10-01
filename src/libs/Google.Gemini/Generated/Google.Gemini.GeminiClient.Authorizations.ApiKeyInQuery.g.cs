
#nullable enable

namespace Google.Gemini
{
    public sealed partial class GeminiClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorizations.Clear();
            _authorizations.Add(new global::Google.Gemini.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Query",
                Name = "key",
                Value = apiKey,
            });
        }
    }
}