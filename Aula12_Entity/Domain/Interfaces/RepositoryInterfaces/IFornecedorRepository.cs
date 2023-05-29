using Aula12_Entity.Domain.Entities;

namespace Aula12_Entity.Domain.Interfaces.RepositoryInterfaces
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        Task<Fornecedor> GetByDocumentAsync(string entityDocument);
        Task<Fornecedor> ObterFornecedorEndereco(int fornecedorId);
        Task<Fornecedor> ObterFornecedorProdutoEndereco(int fornecedorId);
    }
}