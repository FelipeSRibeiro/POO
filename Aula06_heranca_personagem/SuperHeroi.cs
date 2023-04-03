using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_personagem
{
    public class SuperHeroi : Heroi
    {
        public void SuperPoder()
        {
            Console.WriteLine("O super-herói " + Nome + " está usando seus poderes: " + string.Join(", ", Poderes));
        }
    }
}