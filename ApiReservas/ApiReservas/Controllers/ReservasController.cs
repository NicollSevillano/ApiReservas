using ApiReservas.Data;
using ApiReservas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiReservas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Reserva>> Get()
        {
            return await _context.Reserva.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> GetById(Guid id)
        {
            var reserva = await _context.Reserva.Include(x => x.Id).FirstOrDefaultAsync(x => x.Id == id);
            if (reserva is null) return NotFound();
            return reserva;
        }
        [HttpPost]
        public async Task<ActionResult> Create(Reserva reserva)
        {
            _context.Add(reserva);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] Reserva reserva)
        {
            var _reserva = await _context.Reserva.FindAsync(id);
            if (_reserva == null) return NotFound();

            _reserva.Cliente = reserva.Cliente;
            _reserva.Domicilio = reserva.Domicilio;
            _reserva.Barrio = reserva.Barrio;
            _reserva.Fecha = reserva.Fecha;
            _reserva.Hora = reserva.Hora;

            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null) return NotFound();

            _context.Reserva.Remove(reserva);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
