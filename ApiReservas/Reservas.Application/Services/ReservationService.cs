using Reservas.Application.DTOs;
using Reservas.Application.Interfaces;
using Reservas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IClientRepository _clientRepository;

        public ReservationService(IReservationRepository reservationRepository, 
            IClientRepository clientRepository)
        {
            _reservationRepository = reservationRepository;
            _clientRepository = clientRepository;
        }
        public async Task<ReservationDto> CreateReservationAsync(CreateReservationDto dto)
        {
            var client = await _clientRepository.GetByIdAsync(dto.ClientId);
            if (client == null) throw new Exception("Client not found");

            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                ClientId = client.Id,
                Fecha = dto.Fecha,
                TipoReserva = dto.TipoReserva,
                Precio = dto.Precio
            };

            await _reservationRepository.AddAsync(reservation);

            return new ReservationDto
            {
                Id = reservation.Id,
                Fecha = reservation.Fecha,
                TipoReserva = reservation.TipoReserva,
                Precio = reservation.Precio,
                ClienteNombreCompleto = client.NombreCompleto
            };
        }


        public async Task<bool> DeleteReservationAsync(Guid id)
        {
            var reservation = await _reservationRepository.GetByIdAsync(id);
            if (reservation == null) throw new Exception("Reservation not found");

            return await _reservationRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ReservationDto>> GetAllAsync()
        {
            var reservations = await _reservationRepository.GetAllAsync();
            return reservations.Select(r => new ReservationDto
            {
                Id = r.Id,
                ClientId = r.ClientId,
                Fecha = r.Fecha,
                TipoReserva = r.TipoReserva,
                Precio = r.Precio,
                ClienteNombreCompleto = r.Client.NombreCompleto
            });
        }

        public async Task<IEnumerable<ReservationDto>> GetByClientIdAsync(Guid clientId)
        {
            var reservations = await _reservationRepository.GetByClientIdAsync(clientId);

            return reservations.Select(r => new ReservationDto
            {
                Id = r.Id,
                Fecha = r.Fecha,
                TipoReserva = r.TipoReserva,
                Precio = r.Precio,
                ClientId = r.ClientId,
                ClienteNombreCompleto = r.Client?.NombreCompleto ?? ""
            });
        }

        public async Task<ReservationDto?> GetByIdAsync(Guid id)
        {
            var r = await _reservationRepository.GetByIdAsync(id);
            if (r == null) return null;

            return new ReservationDto
            {
                Id = r.Id,
                Fecha = r.Fecha,
                TipoReserva = r.TipoReserva,
                Precio = r.Precio,
                ClientId = r.ClientId,
                ClienteNombreCompleto = r.Client?.NombreCompleto ?? ""
            };
        }

        public async Task<ReservationDto> UpdateReservationAsync(Guid id, UpdateReservationDto dto)
        {
            var reservation = await _reservationRepository.GetByIdAsync(id);
            if (reservation == null) throw new Exception("Reservation not found");

            reservation.Fecha = dto.Fecha;
            reservation.TipoReserva = dto.TipoReserva;
            reservation.Precio = dto.Precio;

            await _reservationRepository.UpdateAsync(reservation);

            return new ReservationDto
            {
                Id = reservation.Id,
                Fecha = reservation.Fecha,
                TipoReserva = reservation.TipoReserva,
                Precio = reservation.Precio,
                ClienteNombreCompleto = reservation.Client.NombreCompleto,
                ClientId = reservation.ClientId 
            };
        }
    }
}
