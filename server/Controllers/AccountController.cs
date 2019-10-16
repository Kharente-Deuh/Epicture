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

namespace server.Controllers
{
    [ApiController]
    [Route("/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IAccountService postService)
        {
            _accountService = postService;
        }

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{accountId}")]
        public async Task<IActionResult> Get(string accountId, [FromHeader]string Authorization)
        {
            var accountBase = await _accountService.GetBase(accountId, Authorization);
            string jsonContent = JsonConvert.SerializeObject(accountBase);
            return Ok(jsonContent);
        }

        [HttpGet("{username}/images/{page}")]
        public async Task<IActionResult> GetImages(string username, int page, [FromHeader]string Authorization)
        {
            var accountBase = await _accountService.GetImages(username, page, Authorization);
            string jsonContent = JsonConvert.SerializeObject(accountBase);
            return Ok(jsonContent);
        }

        [HttpGet("/{username}/settings/")]
        public async Task<IActionResult> GetSettings(string username, [FromHeader]string Authorization)
        {
            var settings = await _accountService.GetSettings(username, Authorization);
            string jsonContent = JsonConvert.SerializeObject(settings);
            return Ok(jsonContent);
        }
    }
}
