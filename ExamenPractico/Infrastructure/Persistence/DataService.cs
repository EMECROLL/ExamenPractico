using ExamenPractico.Application.Interfaces;
using ExamenPractico.Domain.Entities;

namespace ExamenPractico.Infrastructure.Persistence.InMemory
{
    public class DataService : IDataService
    {
        public List<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();

        public List<Vuelo> Vuelos { get; set; } = new List<Vuelo>() 
        { 
            new Vuelo { NumeroVuelo = "A123", Origen = "CUN", Destino = "MEX", FechaSalida = DateTime.Now },
            new Vuelo { NumeroVuelo = "B123", Origen = "CUN", Destino = "MEX", FechaSalida = DateTime.Now.AddDays(1) },
            new Vuelo { NumeroVuelo = "C123", Origen = "MEX", Destino = "CUN", FechaSalida = DateTime.Now.AddDays(2) },
            new Vuelo { NumeroVuelo = "C123", Origen = "MEX", Destino = "CUN", FechaSalida = DateTime.Now.AddDays(3) },
        };

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>()
        {
            new Usuario { Username = "admin", Password = "Password123" }
        };
    }
}
