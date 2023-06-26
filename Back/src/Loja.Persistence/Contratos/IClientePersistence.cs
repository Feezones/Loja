using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;

namespace Loja.Persistence.Contratos
{
    public interface IClientePersistence
    {

        //Clientes
        Task<Cliente[]> GetAllClientesByEmailAsync(string email, bool cpf = false);
        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int ClienteId, bool cpf = false);

    }
}