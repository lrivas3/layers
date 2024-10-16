namespace Layers.Dto.Request;

public class RecordatorioRequest
{
    public string? Usuario { get; set; }
    public DateTime Fecha { get; set; }
    public string Titulo { get; set; }
    public string CreadoPor { get; set; }
    public string? Descripcion { get; set; }
}