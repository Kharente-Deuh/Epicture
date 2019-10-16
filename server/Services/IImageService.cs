
using Refit;
using server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IImageService
    {
        [Get("/{imageHash}")]
        Task<Image> GetById(string imageHash, [Header("Authorization")] string authorization);

        [Delete("/{imageHash}")]
        Task<Basic> Delete(string imageHash, [Header("Authorization")] string authorization);

        [Post("/{imageHash}/favorite")]
        Task<Basic> SetFavorite(string imageHash, [Header("Authorization")] string authorization);
    }
}
