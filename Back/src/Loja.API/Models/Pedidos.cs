using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.API.Models;

namespace Loja.API.Models
{

    public class Pedidos
    {
        public Cliente Cliente { get; set; }
        public List<Item> Itens { get; set; }
        public DateTime DataHora { get; set; }

        public void Pedido()
        {
            Itens = new List<Item>();
            DataHora = DateTime.Now;
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            Itens.Remove(item);
        }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach (var item in Itens)
            {
                valorTotal += item.Preco;
            }
            return valorTotal;
        }
    }
}