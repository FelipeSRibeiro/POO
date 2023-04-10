namespace AP1_conta_bancaria.Captura
{
    public class CapturaTransferencia
    {
        public double Valor { get;  set; }
        public string Origin { get;  set; }
        public string ContaDestino { get; set; }

        public void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite um valor!");
            this.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta de Destino!");
            this.ContaDestino = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta origem!");
            this.Origin = Console.ReadLine();
            Console.WriteLine();
        }
    }
}