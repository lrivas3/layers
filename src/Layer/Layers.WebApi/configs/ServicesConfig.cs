using Layers.Interfaces;
using Layers.Services;

namespace Layers.WebApi.configs;

public static class ServicesConfig
{
    public static void AddServicesConfig(this IServiceCollection services)
    {
        services.AddScoped<IRecordatorio, RecordatorioService>();
    }
}