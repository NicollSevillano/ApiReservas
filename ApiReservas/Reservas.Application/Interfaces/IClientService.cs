using Reservas.Application.DTOs;
using Reservas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.Interfaces
{
    public interface IClientService
    {
        Task<ClientDto> CreateClientAsync(CreateClientDto dto);
        Task<ClientDto> UpdateClientAsync(Guid id, UpdateClientDto dto);
        Task<IEnumerable<ClientDto>> GetAllAsync();
        Task<ClientDto?> GetByIdAsync(Guid id);
        Task<bool> DeleteClientAsync(Guid id);
    }
}
