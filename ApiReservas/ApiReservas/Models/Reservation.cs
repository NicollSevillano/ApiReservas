using System.ComponentModel.DataAnnotations;

namespace ApiReservas.Models
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Client Client { get; set; } = null!;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public required string ReservationType { get; set; }
    }
}
