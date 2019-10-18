
using Refit;
using System;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IAccountsService
    {
        [Get("/{accountId}")]
        Task<Object> GetByIdAsync(string accountId, [Header("Authorization")] string authorization);

        [Get("/{username}/images/{page}")]
        Task<Object> GetImagesAsync(string username, int page, [Header("Authorization")] string authorization);

        [Get("/{username}/settings")]
        Task<Object> GetSettingsAsync(string username, [Header("Authorization")] string authorization);

        [Get("/{username}/favorites/{page}")]
        Task<Object> GetFavoritesAsync(string username, int page, [Header("Authorization")] string authorization);
    }
}
