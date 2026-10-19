namespace ComprasApi.Models;

public class Compra
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Precio { get; set; } = string.Empty;
}