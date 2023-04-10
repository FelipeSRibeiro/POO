namespace AP1_conta_bancaria.Captura
{
    public class CapturaSaque : CapturaTransferencia
    {
        public new void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite um valor!");
            this.Valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta origem!");
            this.Origin = Console.ReadLine();
        }
    }
}