using Layers.DAL;
using Layers.Dto.Request;

namespace Layers.Interfaces.CIT;

public interface IRecordatorio
{
    Recordatorio CrearRecordatorio(RecordatorioRequest recordatorioRequest);
}