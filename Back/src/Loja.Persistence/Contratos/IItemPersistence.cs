using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;

namespace Loja.Persistence.Contratos
{
    public interface IItemPersistence
    {
        //Itens

        Task<Item[]> GetAllItensByNomeAsync(string nome);
        Task<Item[]> GetAllItensAsync(string nome);
        Task<Item> GetItenByIdAsync(int ItemId);

    }
}