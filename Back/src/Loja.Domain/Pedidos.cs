using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;

namespace Loja.Domain
{

    public class Pedidos
    {
        public int PedidoId { get; set; }
        public Cliente ClienteId { get; set; }
        public Cliente ClienteNome { get; set; }
        public IEnumerable<Item> ItensId { get; set; }
        public IEnumerable<Item> Itens { get; set; }
        public Cliente endereco{get;set;}
        public DateTime DataHora { get; set; }

        public void Pedido()
        {
            Itens = new List<Item>();
            DataHora = DateTime.Now;
        }

        public void AdicionarItem(Item item)
        {
            //Itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            //Itens.Remove(item);
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