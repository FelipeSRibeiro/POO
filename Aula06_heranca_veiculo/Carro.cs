using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_heranca_veiculo
{
    public class Carro : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando carro!");
        }
    }
}