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
    [Route("images")]
    public class ImagesController : ControllerBase
    {
        private readonly IImagesService _imagesService;
        private readonly ILogger<ImagesController> _logger;

        public ImagesController(ILogger<ImagesController> logger, IImagesService imagesService)
        {
            _imagesService = imagesService;
            _logger = logger;
        }

        [HttpGet("{imageHash}")]
        public async Task<IActionResult> GetByHash(string imageHash, [FromHeader]string Authorization)
        {
            try
            {

                _logger.LogInformation("Get image: " + imageHash);
                var imageBase = await _imagesService.GetByHashAsync(imageHash, Authorization);
                string jsonContent = JsonConvert.SerializeObject(imageBase);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }

        [HttpDelete("{imageHash}")]
        public async Task<IActionResult> Delete(string imageHash, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Delete image: " + imageHash);
                var imageBase = await _imagesService.DeleteAsync(imageHash, Authorization);
                string jsonContent = JsonConvert.SerializeObject(imageBase);
                return Ok(jsonContent);
            }
            catch (Exception ex)
            {
                var code = int.Parse(ex.Message.Split(' ').FirstOrDefault(s => s.All(char.IsDigit)));
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(code, ex.Message);
            }
        }

        [HttpPost("/{imageHash}/favorite")]
        public async Task<IActionResult> SetFavorite(string imageHash, [FromHeader]string Authorization)
        {
            try
            {
                _logger.LogInformation("Set/unset image as favorite: " + imageHash);
                var settings = await _imagesService.SetFavoriteAsync(imageHash, Authorization);
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
    }
}
