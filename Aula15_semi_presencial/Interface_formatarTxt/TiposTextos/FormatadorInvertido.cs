using Interface_formatarTxt.Interface;

namespace Interface_formatarTxt.TiposTextos
{
    public class FormatadorInvertido : IFormatadorTexto
    {
        public void Formatar(string texto)
        {
            Console.WriteLine(texto.Reverse().ToArray());
        }
    }
}