using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP1_conta_bancaria.Captura;
using AP1_conta_bancaria.Contas;

namespace AP1_conta_bancaria.CriacaoDeObjetos
{
    public class Saque
    {
        public void Sacar()
        {
            CapturaSaque caputura = new CapturaSaque();
            caputura.Captura();

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Sacar(caputura.Origin, caputura.Valor);
        }
    }
}