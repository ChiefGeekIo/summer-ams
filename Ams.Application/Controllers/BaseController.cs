using Microsoft.AspNetCore.Mvc;

namespace Ams.Application.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class BaseController : ControllerBase
{

}