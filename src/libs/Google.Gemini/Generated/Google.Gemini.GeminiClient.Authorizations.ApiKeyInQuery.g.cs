
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query" &&
                    __authorization.Name == "key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Google.Gemini.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyKey",
                Location = "Query",
                Name = "key",
                Value = apiKey,
            });
        }
    }
}