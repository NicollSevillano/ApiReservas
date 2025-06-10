using ApiReservas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiReservas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Reserva> Reserva { get; set; }
    }
}
