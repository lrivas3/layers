using ErrorOr;

namespace Layers.Services.Common.Errors;

public static partial class Errors
{
    public static class Recordatorio
    {
        public static Error NotFoundRecordatorio(string idRecordatorio) => Error.NotFound(
            code: "Recordatorio.NotFoundRecordatorio",
            description: $"El recordatorio no existe o esta inactivo, id = {idRecordatorio}"
        );
    }
}