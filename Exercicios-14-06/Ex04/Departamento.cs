using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex04
{
    internal class Departamento
    {
        public int IdDep { get; set; }
        public List<Funcionario> funcionarios { get; set; }

        public Departamento(int id   )
        {
            this.IdDep = id;
           funcionarios = new List<Funcionario>();
            Console.WriteLine("Novo Departamento criado");
        }
        public void AddFuncionario (int  id , Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine($"novo funcionario adcionado - {funcionario.NomeFuncionario}");
        }
        public void ShowFuncionarios()
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine( funcionario.NomeFuncionario);
            }
        }
    }
}
