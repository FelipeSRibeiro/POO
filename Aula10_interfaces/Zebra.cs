namespace Aula10_interfaces
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {

        private String resolução = "600dpi";
        private String tamEtiqueta = "10cm x 7cm";
        private String tipoEtiqueta = "Poliéster";

        public void ImprimirEtiquetas(Produto produto)
        {
            Console.WriteLine($"\nID: {produto.Id}");
            Console.WriteLine($"ID: {produto.CodBarras}");
            Console.WriteLine($"ID: {produto.Preco}\n");
        }
    }
}