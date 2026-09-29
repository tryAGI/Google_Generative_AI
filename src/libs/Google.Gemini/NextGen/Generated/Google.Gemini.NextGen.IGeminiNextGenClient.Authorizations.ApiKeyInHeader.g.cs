
#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IGeminiNextGenClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}