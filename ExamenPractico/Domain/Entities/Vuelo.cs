namespace ExamenPractico.Domain.Entities
{
    public class Vuelo
    {
        public string NumeroVuelo { get; set; } = string.Empty;
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public DateTime FechaSalida { get; set; }
    }
}
