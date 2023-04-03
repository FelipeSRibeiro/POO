using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_animal
{
    public class Gato : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Miau!");
        }
    }
}