using Aula10_interfaces;

List<IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras>
{
    new Elgin(),
    new Zebra()
};

Console.WriteLine("Digite o código de barras a ser impresso: ");
var codigoBarras = Console.ReadLine();

Produto produto = new Produto()
{
    Id = 1,
    CodBarras = codigoBarras,
    Preco = 9.99
};

foreach(var impressora in impressoras)
{
    impressora.ImprimirEtiquetas(produto);
} 