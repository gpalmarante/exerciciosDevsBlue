using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex02
{
    internal class Escola
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        
        public List<Professor> Professores { get; set; }

        public Escola(string nome, string endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            Professores = new List<Professor>();
            Console.WriteLine($"Nova escola criada - {Nome}");
        }
        public void AddProfessor(Professor prof)
        {
            Professores.Add(prof);
            Console.WriteLine($"Novo Professor Criado - {prof.Nome}");

        }
    }
}
