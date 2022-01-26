using System.Threading.Tasks;
using backend.Interfaces;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _loginService = loginService;
            _logger = logger;
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateAccount()
        {
            var account = _loginService.CreateAccount();
            return new OkObjectResult(account);
        }
    }
}
