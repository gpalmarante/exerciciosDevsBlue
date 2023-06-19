using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Ex01
{
    internal class Carro
    {
        public string Name { get; set; }
        public string Modelo { get; set; }
        public int Id { get; set; }
        public Motor Motor { get; set; }    
       
        public Carro(int id,string name, string modelo,  Motor motor)
        {
            Name = name;
            Modelo = modelo;
            Id = id;
            Motor = motor;
            Console.WriteLine($"Carro criado - {name} e com motor - { motor.Name}");
        }
    }
}
