using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NombreCompleto { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
