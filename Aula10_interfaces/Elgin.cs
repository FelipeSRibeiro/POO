namespace Aula10_interfaces
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        private String resolução = "300dpi";
        private String tamEtiqueta = "10cm x 5cm";
        private String tipoEtiqueta = "Papel Adesivo";

        public void ImprimirEtiquetas(Produto produto)
        {
            Console.WriteLine($"\nID: {produto.Id}");
            Console.WriteLine($"ID: {produto.CodBarras}");
            Console.WriteLine($"ID: {produto.Preco}\n");
        }
    }
}