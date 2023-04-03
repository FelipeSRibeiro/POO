using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_personagem
{
    public class Heroi : Personagem
    {
        public override void Lutar()
        {
            Console.WriteLine("O herói " + Nome + " está lutando com sua força de " + Forca + " e sua inteligência de " + Inteligencia);
        }
    }
}