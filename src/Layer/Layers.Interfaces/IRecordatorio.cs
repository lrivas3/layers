using Layers.Dto.Request;
using Layers.Models;

namespace Layers.Interfaces;

public interface IRecordatorio
{
    Task<Recordatorio?> CrearRecordatorio(RecordatorioRequest recordatorioRequest);
}