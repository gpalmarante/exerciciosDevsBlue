using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex05
{
    internal class Biblioteca
    {
        public Livro Livro { get; set; }
        public Leitor Leitor { get; set; }

        public Emprestimo Emprestimo { get; set; }

        List<Livro> livros = new List<Livro>();
        List<Leitor> leitors = new List<Leitor>();
        public void AddLivro(int id, string nome, string editora, string situacao)
        {
            Livro livro = new Livro(id, nome, editora,  situacao);
            livros.Add(livro);
            Console.WriteLine($"livro - {livro.Nome}");
        }
        public void AddLeitor(int id,string nome, string end, bool situacao)
        {
            Leitor leitor = new Leitor(id,nome, end, situacao);
            leitors.Add(leitor);
            Console.WriteLine($"livro - {leitor.Nome}");

        }
        public void AddEmprestimo(int idLivro ,int idLeitor)
        {
            Emprestimo Ep = new Emprestimo();
            int indexLivro = livros.FindIndex(id => id.Id == idLivro);
            int indexLeitor = leitors.FindIndex(id => id.Id == idLeitor);
           
            if (Ep.GetLivro(livros[indexLivro], leitors[indexLeitor]))
            {
                livros[indexLivro].Situacao = "EMPRESTIMO";
            };
        }
        public void RetornaLivro(int idLivro, int idLeitor)
        {
            Emprestimo Ep = new Emprestimo();
            int indexLivro = livros.FindIndex(id => id.Id == idLivro);
            int indexLeitor = leitors.FindIndex(id => id.Id == idLeitor);

            if (Ep.RetLivro(livros[indexLivro], leitors[indexLeitor]))
            {
                livros[indexLivro].Situacao = "LIVRE";
            };

        }
       
      
    }
}
