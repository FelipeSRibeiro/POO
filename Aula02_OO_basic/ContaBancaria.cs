using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02_OO_basic
{
    public class ContaBancaria
    {
        public double Numero { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria (double numero)
        {
            this.Numero = numero;
        }

        public double Depositar(double valor)
        {
            return this.Saldo =+ valor;
        }

        public Boolean Sacar(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}