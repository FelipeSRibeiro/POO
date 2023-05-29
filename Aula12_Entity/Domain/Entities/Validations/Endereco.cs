namespace Aula12_Entity.Domain.Entities.Validations
{
    public class Endereco : Entity
    {
        public int FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}