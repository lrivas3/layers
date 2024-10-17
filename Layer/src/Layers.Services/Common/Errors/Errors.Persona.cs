using ErrorOr;

namespace Layers.Services.Common.Errors;

public static partial class Errors
{
    public static class Persona
    {
        public static Error NotFoundPersona(int idPersona) => Error.NotFound(
            code: "Persona.NotFoundPersona",
            description: $"La persona no existe o esta inactiva, id = {idPersona}"
        );

        public static Error EmailInvalidForLogging = Error.Conflict(
            code: "Persona.EmailInvalidForLogging",
            description: "Invalid email address"
        );
    }
}
