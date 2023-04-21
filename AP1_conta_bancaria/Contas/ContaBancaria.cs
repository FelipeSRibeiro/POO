using AP1_conta_bancaria.Client;
using AP1_conta_bancaria.Repository;

namespace AP1_conta_bancaria.Contas
{
    public class ContaBancaria
    {
        private static int generateNumber = 1;
        public int Id { get; private set; }
        public string Numero { get; set; }
        public double Saldo { get;  set; }
        public Cliente Cliente { get; set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string numero, double saldo)
        {
            this.Id = generateNumber;
            generateNumber++;
          
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public virtual void ImprimirExtrato()
        {
            Console.WriteLine("Extrato da Conta " + Numero + " - " + Cliente.Nome);
            Console.WriteLine("Saldo: R$ " + Saldo);
        }

        public void ImprimirExtrato(string numeroConta)
        {
            var conta = new ContaBancariaRepository().GetContasBancarias().FirstOrDefault(c => c.Numero == numeroConta);

            if (conta != null)
            {
                if (conta.Cliente != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Extrato da Conta " + conta.Numero + " - " + conta.Cliente.Nome);
                    Console.WriteLine("Saldo: R$ " + conta.Saldo);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Conta bancária não possui cliente associado.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Conta bancária não encontrada.");
            }
        }
    }
}