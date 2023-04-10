using AP1_conta_bancaria.Repository;

namespace AP1_conta_bancaria.Contas
{
    public class ContaCorrente : ContaBancaria
    {
        public  ContaCorrente() : base()
        {
        }

        public void Transferir(double valor, string numeroContaDestino, string numeroContaOrigem)
        {
            var contaOrigem = new ContaBancariaRepository().ProcurarContaBancaria(numeroContaOrigem) as ContaBancaria;
            var contaDestino = new ContaBancariaRepository().ProcurarContaBancaria(numeroContaDestino) as ContaBancaria;

            if (contaDestino != null && contaOrigem != null && contaOrigem.Saldo >= valor)
            {
                contaOrigem.Saldo -= valor;
                contaDestino.Saldo += valor;
                Console.WriteLine("Transferência de R$ " + valor + " realizada com sucesso da conta " + numeroContaOrigem + " para " + numeroContaDestino + ".");
            }
            else if (contaDestino == null)
            {
                Console.WriteLine("Conta destino não encontrada.");
            }
            else if (contaOrigem == null)
            {
                Console.WriteLine("Conta de origem não encontrada.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
            }
        }

        public void Sacar(string numeroContaOrigem, double valor)
        {
            var contaOrigem = new ContaBancariaRepository().ProcurarContaBancaria(numeroContaOrigem) as ContaBancaria;
            if ( contaOrigem != null)
            {
                contaOrigem.Saldo -= valor;
                Console.WriteLine();
                Console.WriteLine("Saque de R$ " + valor + " realizado com sucesso.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                Console.WriteLine();
            }
        }

        public override void ImprimirExtrato()
        {
            base.ImprimirExtrato();
            Console.WriteLine("Tipo de conta: Conta Corrente");
        }
    }
}