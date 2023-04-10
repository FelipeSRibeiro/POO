using AP1_conta_bancaria.Captura;
using AP1_conta_bancaria.Contas;

namespace AP1_conta_bancaria.CriacaoDeObjetos
{
    public class Extrato
    {
        public void ExtratoDaConta()
        {
            CapturaExtrato extrato = new CapturaExtrato();
            extrato.Captura();

            ContaBancaria conta = new ContaBancaria();
            conta.ImprimirExtrato(extrato.Origin);
            
        }
    }
}