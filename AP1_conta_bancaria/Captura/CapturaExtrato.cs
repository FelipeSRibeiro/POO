namespace AP1_conta_bancaria.Captura
{
    public class CapturaExtrato : CapturaSaque
    {
        public new void Captura()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o numero da conta ");
            this.Origin = Console.ReadLine();
        }
    }
}