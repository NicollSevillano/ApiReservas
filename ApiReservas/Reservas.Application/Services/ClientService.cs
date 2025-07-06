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
    public class ClientService : IClientService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IClientRepository _clientRepository;

        public ClientService(IReservationRepository reservationRepository,
            IClientRepository clientRepository)
        {
            _reservationRepository = reservationRepository;
            _clientRepository = clientRepository;
        }
        public async Task<ClientDto> CreateClientAsync(CreateClientDto dto)
        {
            var client = new Client
            {
                NombreCompleto = dto.NombreCompleto,
                Telefono = dto.Telefono,
                Email = dto.Email,
                Direccion = dto.Direccion
            };
            var created = await _clientRepository.AddAsync(client);

            return new ClientDto
            {
                Id = created.Id,
                NombreCompleto = created.NombreCompleto,
                Telefono = created.Telefono,
                Email = created.Email,
                Direccion = created.Direccion,
                Reservations = new List<ReservationDto>() 
            };
        }

        public async Task<bool> DeleteClientAsync(Guid id)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            if (client == null) throw new Exception("Client not found");

            return await _clientRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ClientDto>> GetAllAsync()
        {
            var clients = await _clientRepository.GetAllAsync();

            return clients.Select(client => new ClientDto
            {
                Id = client.Id,
                NombreCompleto = client.NombreCompleto,
                Telefono = client.Telefono,
                Email = client.Email,
                Direccion = client.Direccion,
                Reservations = client.Reservations?.Select(r => new ReservationDto
                {
                    Id = r.Id,
                    Fecha = r.Fecha,
                    TipoReserva = r.TipoReserva,
                    Precio = r.Precio
                }).ToList()
            });
        }


        public async Task<ClientDto?> GetByIdAsync(Guid id)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            if (client == null) return null;

            return new ClientDto
            {
                Id = client.Id,
                NombreCompleto = client.NombreCompleto,
                Telefono = client.Telefono,
                Email = client.Email,
                Direccion = client.Direccion,
                Reservations = client.Reservations?.Select(r => new ReservationDto
                {
                    Id = r.Id,
                    Fecha = r.Fecha,
                    TipoReserva = r.TipoReserva,
                    Precio = r.Precio
                }).ToList() ?? new List<ReservationDto>()
            };
        }

        public async Task<ClientDto> UpdateClientAsync(Guid id, UpdateClientDto dto)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            if (client == null) throw new Exception("Client not found");

            client.NombreCompleto = dto.NombreCompleto;
            client.Telefono = dto.Telefono;
            client.Direccion = dto.Direccion;

            await _clientRepository.UpdateAsync(client);

            return new ClientDto
            {
                Id = client.Id,
                NombreCompleto = client.NombreCompleto,
                Telefono = client.Telefono,
                Email = client.Email,
                Direccion = client.Direccion,
                Reservations = client.Reservations?.Select(r => new ReservationDto
                {
                    Id = r.Id,
                    Fecha = r.Fecha,
                    TipoReserva = r.TipoReserva,
                    Precio = r.Precio
                }).ToList() ?? new List<ReservationDto>()
            };
        }
    }
}
