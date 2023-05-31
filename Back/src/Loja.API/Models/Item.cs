using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.API.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Img { get; set; }
        public decimal Preco { get; set; }
    }
}