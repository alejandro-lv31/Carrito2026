namespace UsuariosApi.Models;

public class Usuario
{
    public int Id { get; set; }
    public string nombre { get; set; } = string.Empty;
    public string TarjetasDePagos { get; set; } = string.Empty;
}