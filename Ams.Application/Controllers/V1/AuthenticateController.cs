using Microsoft.AspNetCore.Mvc;
using Ams.Application.Controllers;

namespace Ams.Application.Controllers.V1;

[ApiVersion("1.0")]
public class AuthenticateController : BaseController
{
    private readonly ILogger<AuthenticateController> _logger;

    public AuthenticateController(ILogger<AuthenticateController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "This is here.";
    }
}