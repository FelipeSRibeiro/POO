using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_veiculo
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }

        public abstract void Acelerar();
    }
}