using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex04
{
    internal class Funcionario
    {

        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public Funcionario()
        {

        }
        public Funcionario(int id , string nome)
        {
                this.IdFuncionario = id;
            this.NomeFuncionario = nome;
        }

    }
}
