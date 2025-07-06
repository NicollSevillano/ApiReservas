using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Reservas.Application.DTOs
{
    public class UpdateClientDto
    {
        [Required(ErrorMessage = "El nombre completo es obligatorio.")]
        [StringLength(100)]
        public string NombreCompleto { get; set; } = null!;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone]
        public string Telefono { get; set; } = null!;
        
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; } = null!;
    }
}
