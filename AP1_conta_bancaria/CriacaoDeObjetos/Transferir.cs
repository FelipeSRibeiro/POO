using AP1_conta_bancaria.Captura;
using AP1_conta_bancaria.Contas;

namespace AP1_conta_bancaria.CriacaoDeObjetos
{
    public class Transferir
    {
        public void Transferencia()
        {
            CapturaTransferencia captura = new CapturaTransferencia();
            captura.Captura();

            ContaCorrente conta = new ContaCorrente();
            conta.Transferir(captura.Valor, captura.ContaDestino, captura.Origin);
        }
    }
}