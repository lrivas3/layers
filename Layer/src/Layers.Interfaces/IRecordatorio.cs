using ErrorOr;
using Layers.Dto.Request;
using Layers.Models;

namespace Layers.Interfaces;

public interface IRecordatorio
{
    Task<ErrorOr<Recordatorio?>> CrearRecordatorio(RecordatorioRequest recordatorioRequest);
}