namespace Layers.Services.Utils;

public class Generals
{
    public static string GetCodigo()
    {
        var guid = Guid.NewGuid().ToString();
        var codigo = string.Join("", guid.Split('-'));
        return codigo;
    }
}