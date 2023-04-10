using AP1_conta_bancaria.Repository;

namespace AP1_conta_bancaria.AtualizarCliente
{
    public class AtualizarCliente
    {
        private readonly ClienteRepository clienteRepository;

        public AtualizarCliente()
        {
            clienteRepository = new ClienteRepository();
        }

        public void Atualizar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite Nome da pessoa para Atualizar");
            var update1 = Console.ReadLine();

            bool nomeExiste = clienteRepository.ClienteExiste(update1);

            if (nomeExiste)
            {
                var cliente = clienteRepository.GetClientes().FirstOrDefault(x => x.Nome == update1);

                Console.WriteLine();
                Console.WriteLine("Digite um novo Endereço");
                cliente.Endereco = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Endereço atualizado com sucesso +" + cliente.Endereco);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("A pessoa não foi encontrada na lista");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
            }
        }
    }
}