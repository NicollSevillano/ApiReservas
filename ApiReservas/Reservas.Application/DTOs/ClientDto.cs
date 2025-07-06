using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.DTOs
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? Email { get; set; }
        public string Direccion { get; set; } = null!;
        public List<ReservationDto>? Reservations { get; set; } = new();
    }

}
