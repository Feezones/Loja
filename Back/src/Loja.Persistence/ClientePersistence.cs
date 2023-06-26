using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;
using Loja.Persistence.Contexto;
using Loja.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;

namespace Loja.Persistence
{
    public class ClientePersistence : IClientePersistence
    {
        private readonly LojaContext _context;
        public ClientePersistence(LojaContext context)
        {
            _context = context;
            
        }


        public async Task<Cliente[]> GetAllClientesAsync()
        {
            IQueryable<Cliente> query = _context.Clientes;

            query = query.OrderBy(e=>e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente[]> GetAllClientesByEmailAsync(string email, bool cpf = false)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(e => e.CPF);
        if(cpf){
            query = query.Include(e => e.CPF);
        }
            query = query.OrderBy(e=>e.Id)
                          .Where(e => e.Email.ToLower().Contains(email.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int ClienteId, bool cpf)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(e => e.CPF);

            if(cpf){
                query = query.Include(e => e.CPF);
            }

            query = query.OrderBy(e=>e.Id)
                          .Where(e => e.Id == ClienteId);

            return await query.FirstOrDefaultAsync();
        }


    }
}