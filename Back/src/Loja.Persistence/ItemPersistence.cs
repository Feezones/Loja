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
    public class ItemPersistence : IItemPersistence
    {
        private readonly LojaContext _context;
        public ItemPersistence(LojaContext context)
        {
            _context = context;
            
        }


        public async Task<Item[]> GetAllItensAsync(string nome)
        {
            IQueryable<Item> query = _context.Itens;

            query = query.OrderBy(e=>e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Item[]> GetAllItensByNomeAsync(string nome)
        {
            IQueryable<Item> query = _context.Itens
                .Include(e => e.Nome);

            query = query.OrderBy(e=>e.Id)
                          .Where(e => e.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }
        public async Task<Item> GetItenByIdAsync(int ItemId)
        {
            IQueryable<Item> query = _context.Itens
                .Include(e => e.Nome);

            query = query.OrderBy(e=>e.Id)
                          .Where(e => e.Id == ItemId);

            return await query.FirstOrDefaultAsync();
        }


    }
}