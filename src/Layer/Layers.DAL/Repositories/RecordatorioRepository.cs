using Layers.Interfaces.Repositories;
using Layers.Models;

namespace Layers.DAL.Repositories;

public class RecordatorioRepository : IRecordatorioRepository
{
    private readonly DatabaseContext _context;

    public RecordatorioRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Recordatorio?> AddRecordatorio(Recordatorio recordatorio)
    { 
        await _context.Recordatorios.AddAsync(recordatorio);
        var guardados = await _context.SaveChangesAsync();
        return guardados > 0 ? recordatorio : null;
    }
}