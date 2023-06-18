using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex05
{
    internal class Emprestimo
    {



        public Boolean GetLivro(Livro livro, Leitor Leitor)
        {
            if (livro.Situacao == "LIVRE" && Leitor.Ativo)
            {
                Console.WriteLine("Livro emprestado");
                return true;
            }
            if (livro.Situacao == "EMPRESTIMO")
            {
                Console.WriteLine("** Livro NAO DISPONIVEL para emprestimo");
                return false;
            }
            if (!Leitor.Ativo)
            {
                Console.WriteLine("**Usuario DESATIVADO**");
                return false;
            }
            else
            {
                return false;
            }
            

        }


    }
}
