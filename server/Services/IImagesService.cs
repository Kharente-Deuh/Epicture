
using Refit;
using System;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IImagesService
    {
        [Get("/{imageHash}")]
        Task<Object> GetByHashAsync(string imageHash, [Header("Authorization")] string authorization);

        [Delete("/{imageHash}")]
        Task<Object> DeleteAsync(string imageHash, [Header("Authorization")] string authorization);

        [Post("/{imageHash}/favorite")]
        Task<Object> SetFavoriteAsync(string imageHash, [Header("Authorization")] string authorization);
    }
}
