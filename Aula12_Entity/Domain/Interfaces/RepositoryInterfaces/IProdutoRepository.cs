using Aula12_Entity.Domain.Entities;

namespace Aula12_Entity.Domain.Interfaces.RepositoryInterfaces
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Task<IList<Produto>> ObterProdutosPorFornecedor(int fornecedorId);
        Task<IList<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(int id);
    }
}