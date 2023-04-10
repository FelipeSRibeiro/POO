namespace AP1_conta_bancaria.Captura
{
    public class CapturaContaBancaria
    {
        public string Numero { get; private set;}
        public double Saldo { get; private set; }

        public void capturaConta()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o Numero da conta desejada!");
            this.Numero = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o Deposito da sua conta!");
            this.Saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
    }
}