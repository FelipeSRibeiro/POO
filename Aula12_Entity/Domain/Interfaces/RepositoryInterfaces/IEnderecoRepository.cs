using Aula12_Entity.Domain.Entities;

namespace Aula12_Entity.Domain.Interfaces.RepositoryInterfaces
{
    public interface IEnderecoRepository : IBaseRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(int fornecedorId);
    }
}