using Microsoft.EntityFrameworkCore;
using Reservas.Application.Interfaces;
using Reservas.Domain.Entities;
using Reservas.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _context;
        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Reservation> AddAsync(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return reservation;
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await _context.Reservations
                .Include(r => r.Client)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByClientIdAsync(Guid clientId)
        {
            return await _context.Reservations
                .Where(r => r.ClientId == clientId)
                .ToListAsync();
        }

        public async Task<Reservation> GetByIdAsync(Guid id)
        {
            return await _context.Reservations
                .Include(r => r.Client)
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
