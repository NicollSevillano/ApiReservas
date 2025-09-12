namespace Reservas.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoReserva { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
