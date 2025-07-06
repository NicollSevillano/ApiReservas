using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.DTOs
{
    public class CreateReservationDto
    {
        [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "La fecha de la reserva es obligatoria.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El tipo de reserva es obligatorio.")]
        public string TipoReserva { get; set; } = null!;

        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0.")]
        public decimal Precio { get; set; }
    }
}
