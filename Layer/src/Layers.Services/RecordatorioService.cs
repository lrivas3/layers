using ErrorOr;
using Layers.Dto.Request;
using Layers.Interfaces;
using Layers.Interfaces.Repositories;
using Layers.Models;
using Layers.Services.Common.Errors;
using Layers.Services.Utils;

namespace Layers.Services;

public class RecordatorioService : IRecordatorio
{
    private readonly IRecordatorioRepository _recordatorioRepository;

    public RecordatorioService(IRecordatorioRepository recordatorioRepository)
    {
        _recordatorioRepository = recordatorioRepository;
    }

    public async Task<ErrorOr<Recordatorio?>> CrearRecordatorio(RecordatorioRequest recordatorioRequest)
    {
        var nuevoRecordatorio = new Recordatorio
        {
            Id = Generals.GetCodigo(),
            UsuarioId = recordatorioRequest.Usuario,
            Fecha = recordatorioRequest.Fecha,
            Titulo = recordatorioRequest.Titulo,
            Descripcion = recordatorioRequest.Descripcion,
            Activo = true,
            FechaCreacion = DateTime.Now,
            CreadoPor = recordatorioRequest.CreadoPor,
        };

        var guardado = await _recordatorioRepository.AddRecordatorio(nuevoRecordatorio);

        if (guardado is null)
        {
            return Errors.Recordatorio.NotFoundRecordatorio(nuevoRecordatorio.Id);
        }

        return guardado;
    }
}