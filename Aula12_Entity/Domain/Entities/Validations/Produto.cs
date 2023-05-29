namespace Aula12_Entity.Domain.Entities.Validations
{
    public class Produto : Entity
    {
        public int FornecedorId { get; set;}

        public string Nome { get; set;}
        public string Descricao { get; set;}
        public string Imagem { get; set;}
        public decimal valor { get; set;}
        public DateTime DataCadastro { get; set;}

        public Fornecedor Fornecedor { get; set;}
    }
}