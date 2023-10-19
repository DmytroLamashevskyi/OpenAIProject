using Refit;
using webapi.Models.Request;
using webapi.Models.Response;

namespace OpenAIClient
{
    public interface IOpenAIClient
    {

        [Headers("Content-Type: application/json")]
        [Post("/images/generations")]
        Task<ImageGenResponse> GetImagesGenerations([Header("Authorization")] string bearerToken, [Body] ImageGenRequest request);
    }
}