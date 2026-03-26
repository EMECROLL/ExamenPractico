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

        public List<VueloDTO> GetVuelosByDateRange(DateTime fechaInicio, DateTime fechaFin)
        {
            var inicio = fechaInicio.Date;
            var fin = fechaFin.Date;

            if (inicio > fin)
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha final");
            }

            var vuelos = _dataService.Vuelos
            .Where(x => x.FechaSalida.Date >= inicio && x.FechaSalida.Date <= fin)
            .Select(x => new VueloDTO
            {
                NumeroVuelo = x.NumeroVuelo,
                Origen = x.Origen,
                Destino = x.Destino,
                FechaSalida = x.FechaSalida.Date
            })
            .ToList();

            return vuelos;
        }
    }
}
