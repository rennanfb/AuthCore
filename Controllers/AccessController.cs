using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthCore.Controllers;

[ApiController]
[Route("[controller]")]
public class AccessController : ControllerBase
{
    [HttpGet]
    [Authorize (Policy = "MinimunAge")]
    public IActionResult Get()
    {
        return Ok("ok");
    }
}

