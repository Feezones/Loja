using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Domain;

namespace Loja.Domain
{

    public class Pedidos
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string NomeCliente { get; set; }
        public Item Itens { get; set; }
        public string NomeItem { get; set; }
        public DateTime DataPedido { get; set; }
        public string Endereco { get; set; }
        public decimal ValorTotal { get; set; }


    }
}