
#nullable enable

namespace Google.Gemini.NextGen
{
    public sealed partial class EnvironmentsClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-goog-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Google.Gemini.NextGen.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyXGoogApiKey",
                Location = "Header",
                Name = "x-goog-api-key",
                Value = apiKey,
            });
        }
    }
}