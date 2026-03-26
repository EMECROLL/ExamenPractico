using ExamenPractico.Application.DTOs.Vuelos;
using ExamenPractico.Application.Interfaces;
using ExamenPractico.Domain.Entities;

namespace ExamenPractico.Application.Services
{
    public class VueloService : IVueloService
    {
        private readonly IDataService _dataService;

        public VueloService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public bool CrearListaVuelos(List<VueloCreateDTO> vuelos)
        {
            if (vuelos is null)
            {
                return false;
            }

            var nuevosVuelos = vuelos.Select(v => new Vuelo
            {
                NumeroVuelo = v.NumeroVuelo,
                Origen = v.Origen,
                Destino = v.Destino,
                FechaSalida = v.FechaSalida
            }).ToList();

            var totalAntes = _dataService.Vuelos.Count;
            _dataService.Vuelos.AddRange(nuevosVuelos);
            var insertados = _dataService.Vuelos.Count - totalAntes;

            return insertados == nuevosVuelos.Count;
        }

        public List<VueloDTO> GetVuelosByDateRange(string fechaInicio, string fechaFin)
        {
            var inicio = DateTime.Parse(fechaInicio).Date;
            var fin = DateTime.Parse(fechaFin).Date.AddDays(1).AddTicks(-1);

            if (inicio > fin)
            {
                throw new Exception("La fecha de inicio no puede ser mayor que la fecha final");
            }

            var vuelos = _dataService.Vuelos
            .Where(x => x.FechaSalida >= inicio && x.FechaSalida <= fin)
            .Select(x => new VueloDTO
            {
                NumeroVuelo = x.NumeroVuelo,
                Origen = x.Origen,
                Destino = x.Destino,
                FechaSalida = x.FechaSalida.ToString("yyyy/MM/dd hh:mm:ss")
            })
            .ToList();

            return vuelos;
        }
    }
}
