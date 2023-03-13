using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02_OO_basic
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Seu nome é " + Nome + " e você tem " + Idade + " anos!");
        }
    }
}