using ApiReservas.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Reservations")]
public class ReservationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ReservationsController(ApplicationDbContext context)
    {
        _context = context;
    }

}