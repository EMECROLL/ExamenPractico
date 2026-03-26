using ExamenPractico.Application.DTOs.Pasajeros;
using ExamenPractico.Application.Interfaces;
using ExamenPractico.Domain.Entities;

namespace ExamenPractico.Application.Services;

public class PasajeroService : IPasajeroService
{
    private readonly IDataService _dataService;

    public PasajeroService(IDataService dataService)
    {
        _dataService = dataService;
    }

    public Pasajero CrearPasajero(PasajeroCreateDTO dto)
    {
        var pasajero = new Pasajero
        {
            Nombre = dto.Nombre.Trim(),
            Apellido = dto.Apellido.Trim()
        };

        _dataService.Pasajeros.Add(pasajero);
        return pasajero;
    }

    public bool CrearListaPasajeros(List<PasajeroCreateDTO> pasajeros)
    {
        if (pasajeros is null)
        {
            return false;
        }

        var nuevosPasajeros = pasajeros.Select(dto => new Pasajero
        {
            Nombre = dto.Nombre.Trim(),
            Apellido = dto.Apellido.Trim()
        }).ToList();

        var totalAntes = _dataService.Pasajeros.Count;
        _dataService.Pasajeros.AddRange(nuevosPasajeros);
        var insertados = _dataService.Pasajeros.Count - totalAntes;

        return insertados == nuevosPasajeros.Count;
    }

    public List<Pasajero> ListarPasajeros()
    {
        return _dataService.Pasajeros;
    }
}
