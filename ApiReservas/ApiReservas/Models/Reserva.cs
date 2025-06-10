namespace ApiReservas.Models
{
    public class Reserva
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Cliente { get; set; }
        public string Domicilio { get; set; }
        public string Barrio { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
