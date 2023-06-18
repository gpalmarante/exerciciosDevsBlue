using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex05
{
    internal class Leitor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Boolean Ativo { get; set; }
        public Leitor()
        {

        }
        public Leitor(int id,string nome, string endereco, bool ativo)
        {
            this.Id = id;
            Nome = nome;
            Endereco = endereco;
            Ativo = ativo;
        }
    }
}
