using Interface_formatarTxt.Interface;

namespace Interface_formatarTxt.TiposTextos
{
    public class FormatadorMinusculo : IFormatadorTexto
    {
        public void Formatar(string texto)
        {
            Console.WriteLine(texto.ToLower());
        }
    }
}