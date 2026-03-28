#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a `Corpus`.
        /// </summary>
        /// <param name="force"></param>
        /// <param name="corporaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Empty> CorporaDeleteAsync(
            string corporaId,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}