using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex03
{
    internal class Pedido
    {
        public int IdPedido { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public Pedido(int idPedido)
        {
            IdPedido = idPedido;
            Itens = new List<ItemPedido>();    

        }
        public void AddItemPedido(ItemPedido item)
        {
           Itens.Add(item);
            Console.WriteLine($"novo item adicionado - {item.NomeItem}");
        }
    }
}
