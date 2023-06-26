using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;

namespace Loja.Application.Contrato
{
    public interface IClienteService
    {
        Task<Cliente>AddClientes(Cliente model);
        Task<Cliente>UpdateCliente(int Clienteid,Cliente model);
        Task<bool>DeleteCliente(int model);

        Task<Cliente[]> GetAllClientesByEmailAsync(string email, bool cpf = false);
        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int ClienteId, bool cpf = false);
    }
}