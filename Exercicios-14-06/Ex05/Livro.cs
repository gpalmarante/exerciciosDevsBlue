using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex05
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
       
        public string Situacao { get; set; }
        public Livro()
        {

        }
        public Livro(int id, string nome, string editora,  string situacao)
        {
            Id = id;
            Nome = nome;
            Editora = editora;           
            Situacao = situacao;
        }

    }
}
