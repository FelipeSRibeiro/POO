using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_personagem
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public string[] Poderes { get; set; }

        public abstract void Lutar();
    }
}