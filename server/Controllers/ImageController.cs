using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Refit;
using server.Services;
using System.Threading.Tasks;

namespace server.Controllers
{
    [ApiController]
    [Route("/image")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;
        private readonly ILogger<ImageController> _logger;

        public ImageController(IImageService postService)
        {
            _imageService = postService;
        }

        public ImageController(ILogger<ImageController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{imageHash}")]
        public async Task<IActionResult> Get(string imageHash, [FromHeader]string Authorization)
        {
            var imageBase = await _imageService.GetById(imageHash, Authorization);
            string jsonContent = JsonConvert.SerializeObject(imageBase);
            return Ok(jsonContent);
        }

        [HttpDelete("{imageHash}")]
        public async Task<IActionResult> GetImages(string imageHash, [FromHeader]string Authorization)
        {
            var imageBase = await _imageService.Delete(imageHash, Authorization);
            string jsonContent = JsonConvert.SerializeObject(imageBase);
            return Ok(jsonContent);
        }

        [HttpPost("/{imageHash}/favorite")]
        public async Task<IActionResult> SetFavorite(string imageHash, [FromHeader]string Authorization)
        {
            var settings = await _imageService.SetFavorite(imageHash, Authorization);
            string jsonContent = JsonConvert.SerializeObject(settings);
            return Ok(jsonContent);
        }
    }
}
