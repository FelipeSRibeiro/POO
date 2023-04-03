using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_personagem
{
    public class Vilao : Personagem
    {
        public override void Lutar()
        {
            Console.WriteLine("O vilão " + Nome + " está lutando com sua força de " + Forca + " e sua inteligência de " + Inteligencia);
        }
    }
}