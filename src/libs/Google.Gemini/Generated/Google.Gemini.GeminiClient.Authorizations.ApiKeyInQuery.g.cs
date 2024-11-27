
#nullable enable

namespace Google.Gemini
{
    public sealed partial class GeminiClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Google.Gemini.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Query",
                Name = "key",
                Value = apiKey,
            });
        }
    }
}