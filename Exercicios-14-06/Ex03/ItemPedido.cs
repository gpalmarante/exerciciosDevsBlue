using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex03
{
    internal class ItemPedido
    {
        public int Id { get; set; }
        public string NomeItem { get; set; }
        public ItemPedido(int id, string nomeItem)
        {
            Id = id;
            NomeItem = nomeItem;
            Console.WriteLine($"novo item criado id {id}");
        }
    }
}
