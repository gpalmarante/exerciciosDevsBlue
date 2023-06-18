using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex01
{
    internal class Motor
    {   public int Id { get; set; }
        public string Name { get; set; }
        public int Cilindros { get; set; }
        public int Potencia { get; set; }

        public Motor(int id, string name, int cilindros, int potencia)
        {
            Id = id;
            Name = name;
            Cilindros = cilindros;
            Potencia = potencia;
        }
    }
}
