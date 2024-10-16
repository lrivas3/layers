using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LayersController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}