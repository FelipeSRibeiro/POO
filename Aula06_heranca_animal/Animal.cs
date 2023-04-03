using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_animal
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract void Falar();
    }
}