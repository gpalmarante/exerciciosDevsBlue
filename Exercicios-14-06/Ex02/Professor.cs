using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex02
{
    internal class Professor
    {
        public string Nome { get; set; }
        public string Materia { get; set; }
        public Professor( string nome, string materia  )
        {
            this.Nome = nome;
            this.Materia = materia;
        }
    }
}
