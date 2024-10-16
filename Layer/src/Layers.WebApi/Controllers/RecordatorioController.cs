using Layers.Dto.Request;
using Layers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Controllers;

[Route("api/recordatorio")]
[ApiController]
public class RecordatorioController : ControllerBase
{
    private readonly IRecordatorio _recordatorio;

    public RecordatorioController(IRecordatorio recordatorio)
    {
        _recordatorio = recordatorio;
    }

    [HttpPost]
    public async Task<IActionResult> CreateRecordatorio(RecordatorioRequest recordatorioRequest)
    { 
        return  Ok(await _recordatorio.CrearRecordatorio(recordatorioRequest));
    }
}