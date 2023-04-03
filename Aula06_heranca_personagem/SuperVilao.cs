using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_personagem
{
    public class SuperVilao : Vilao
    {
        public void SuperPoder()
        {
            Console.WriteLine("O super-vilão " + Nome + " está usando seus poderes: " + string.Join(", ", Poderes));
        }
    }
}