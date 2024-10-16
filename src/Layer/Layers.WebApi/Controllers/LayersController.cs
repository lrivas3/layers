using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Controllers;

public class LayersController : ControllerBase
{
    public IActionResult Index()
    {
        return Ok();
    }
}