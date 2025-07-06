using Reservas.Application.DTOs;
using Reservas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.Interfaces
{
    public interface IReservationService
    {
        Task<ReservationDto> CreateReservationAsync(CreateReservationDto dto);
        Task<IEnumerable<ReservationDto>> GetAllAsync();
        Task<ReservationDto?> GetByIdAsync(Guid id);
        Task<ReservationDto> UpdateReservationAsync(Guid id, UpdateReservationDto dto);
        Task<bool> DeleteReservationAsync(Guid id);
        Task<IEnumerable<ReservationDto>> GetByClientIdAsync(Guid clientId);
    }
}
