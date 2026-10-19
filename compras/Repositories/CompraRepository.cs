using ComprasApi.Models;

namespace ComprasApi.Repositories;

public interface ILibroRepository
{
    List<Compra> ObtenerTodos();

    Compra? ObtenerPorId(int id);

    Compra Agregar(Compra compra);

    bool Eliminar(int id);
}
