using Aula12_Entity.Domain.Enums;

namespace Aula12_Entity.Domain.Entities.Validations
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedorEnum TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public IList<Produto> Produtos { get; set; }
    }
}