using ExamenPractico.Domain.Entities;

namespace ExamenPractico.Application.Interfaces
{
    public interface IDataService
    {
        List<Pasajero> Pasajeros { get; set; }
        List<Vuelo> Vuelos { get; set; }
        List<Usuario> Usuarios { get; set; }
    }
}
