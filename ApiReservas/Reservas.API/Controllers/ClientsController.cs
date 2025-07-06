using Microsoft.AspNetCore.Mvc;
using Reservas.Application.DTOs;
using Reservas.Application.Interfaces;

namespace Reservas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IReservationService _reservationService;

        public ClientsController(IClientService clientService, 
            IReservationService reservationService)
        {
            _clientService = clientService;
            _reservationService = reservationService;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateClientDto dto)
        {
            var client = await _clientService.CreateClientAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = client.Id }, client);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateClientDto dto)
        {
            try
            {
                var update = await _clientService.UpdateClientAsync(id, dto);
                return Ok(update);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _clientService.GetAllAsync();
            return Ok(clients);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var client = await _clientService.GetByIdAsync(id);
            if (client == null) return NotFound(new { message = "Client not found" });
            return Ok(client);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _clientService.DeleteClientAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpGet("{id}/reservations")]
        public async Task<IActionResult> GetReservations(Guid id)
        {
            var reservations = await _reservationService.GetByClientIdAsync(id);
            return Ok(reservations);
        }
    }
}
