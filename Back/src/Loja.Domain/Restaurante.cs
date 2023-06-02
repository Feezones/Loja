using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public class Restaurante
    {
        public IEnumerable<Pedidos> PedidosRecebidos { get; set; }

        public Restaurante()
        {
            PedidosRecebidos = new List<Pedidos>();
        }

        public void AdicionarPedido(Pedidos pedido)
        {
            //PedidosRecebidos.Add(pedido);
        }

        public void ConfirmarPedido(Pedidos pedido)
        {
            // Lógica para confirmar o pedido com o cliente
        }

        public void EnviarPedido(Pedidos pedido, string local)
        {
            // Lógica para enviar o pedido ao local escolhido pelo cliente
        }
    }
}