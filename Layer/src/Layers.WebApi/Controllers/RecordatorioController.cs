using Layers.Dto.Request;
using Layers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Controllers;

[Route("api/recordatorio")]
[ApiController]
public class RecordatorioController : ApiController
{
    private readonly IRecordatorio _recordatorio;

    public RecordatorioController(IRecordatorio recordatorio)
    {
        _recordatorio = recordatorio;
    }

    [HttpPost]
    public async Task<IActionResult> CreateRecordatorio(RecordatorioRequest recordatorioRequest)
    {
        var result = await _recordatorio.CrearRecordatorio(recordatorioRequest);
        return result.Match(
            recordatorio => Ok(recordatorio),
            error => Problem(error));
    }
}