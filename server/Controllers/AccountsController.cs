using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using server.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace server.Controllers
{
    [ApiController]
    [Route("accounts")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsService _accountsService;
        private readonly ILogger<AccountsController> _logger;
        public AccountsController(ILogger<AccountsController> logger, IAccountsService accountsService)
        {
            _logger = logger;
            _accountsService = accountsService;
        }

        [HttpGet("{accountId}")]
        public async Task<IActionResult> GetById(string accountId, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Get accout: " + accountId);
                var accountBase = await _accountsService.GetByIdAsync(accountId, Authorization);
                string jsonContent = JsonConvert.SerializeObject(accountBase);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }

        [HttpGet("{username}/images/{page}")]
        public async Task<IActionResult> GetImages(string username, int page, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Get images from: " + username + " - page: " + page);
                var accountBase = await _accountsService.GetImagesAsync(username, page, Authorization);
                string jsonContent = JsonConvert.SerializeObject(accountBase);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }

        [HttpGet("/{username}/settings")]
        public async Task<IActionResult> GetSettings(string username, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Get settings from: " + username);
                var settings = await _accountsService.GetSettingsAsync(username, Authorization);
                string jsonContent = JsonConvert.SerializeObject(settings);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }

        [HttpGet("{username}/favorites/{page}")]
        public async Task<IActionResult> GetFavorites(string username, int page, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Get images from: " + username + " - page: " + page);
                var favorites = await _accountsService.GetFavoritesAsync(username, page, Authorization);
                string jsonContent = JsonConvert.SerializeObject(favorites);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }
    }
}
