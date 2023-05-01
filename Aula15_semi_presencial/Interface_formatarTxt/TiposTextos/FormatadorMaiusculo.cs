using Interface_formatarTxt.Interface;

namespace Interface_formatarTxt.TiposTextos
{
    public class FormatadorMaiusculo : IFormatadorTexto
    {
        public void Formatar(string texto)
        {
            Console.WriteLine(texto.ToUpper());
        }
    }
}