using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layers.Models;

[Table("Recordatorio", Schema = "CIT")]
public class Recordatorio
{
    [Key]
    public string Id { get; set; } = null!;

    public string? UsuarioId { get; set; }

    public DateTime? Fecha { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string CreadoPor { get; set; } = null!;

    public string? Identificador { get; set; }
}
