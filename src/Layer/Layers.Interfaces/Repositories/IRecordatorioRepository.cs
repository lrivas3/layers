using Layers.Models;

namespace Layers.Interfaces.Repositories;

public interface IRecordatorioRepository
{
    Task<Recordatorio?> AddRecordatorio(Recordatorio recordatorio);
}