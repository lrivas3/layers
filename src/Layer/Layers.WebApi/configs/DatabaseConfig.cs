using Layers.DAL;
using Layers.DAL.Repositories;
using Layers.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Layers.WebApi.configs;

public static class DatabaseConfig
{
    public static void AddPersistance(this IServiceCollection services, string databaseConnection)
    {
        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(databaseConnection));
        services.AddScoped<IRecordatorioRepository, RecordatorioRepository>();
    }
}