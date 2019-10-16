
using Refit;
using server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IAccountService
    {
        [Get("/{accountId}")]
        Task<Account> GetBase(string accountId, [Header("Authorization")] string authorization);

        [Get("/{username}/images/{page}")]
        Task<Image[]> GetImages(string username, int page, [Header("Authorization")] string authorization);

        [Get("/{username}/settings/")]
        Task<BlockedUser> GetSettings(string username, [Header("Authorization")] string authorization);

        //en cours parce que c'est de la bonne grosse merde a envoyer un tableau d'items DE DEUX TYPES DIFFERENTS
        //[Get("/{username}/favorites/")]
        //Task<PostedImage[]> GetAccountFavorites([Header("Authorization")] string authorization);
    }
}
