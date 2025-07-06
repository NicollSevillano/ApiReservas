using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.DTOs
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoReserva { get; set; } = null!;
        public decimal Precio { get; set; }
        public string ClienteNombreCompleto { get; set; } = null!;
    }

}
