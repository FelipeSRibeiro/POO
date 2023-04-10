using AP1_conta_bancaria.Client;

namespace AP1_conta_bancaria.Repository
{
    public class ClienteRepository
    {
        public static List<Cliente> clienteMaster = new List<Cliente>();

        public void AddCliente(Cliente cliente)
        {
            clienteMaster.Add(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return clienteMaster;
        }

        public void Atualizar(int clienteId, Cliente cliente)
        {
            Cliente clienteAtualizar = clienteMaster.FirstOrDefault(p => p.Id == clienteId);

            if (clienteAtualizar != null)
            {
                clienteAtualizar.Endereco = cliente.Endereco;
            }
        }


        public bool ClienteExiste(string nome)
        {
            return clienteMaster.Any(p => p.Nome == nome);
        }

        public void DeletarCliente(int clienteID)
        {
            Cliente removerCliente = clienteMaster.FirstOrDefault(cliente => cliente.Id == clienteID);

            if (removerCliente != null)
            {
       
                bool temSaldo = removerCliente.ContaBancaria.Saldo > 0;

                if (!temSaldo)
                {
                    clienteMaster.Remove(removerCliente);
                    Console.WriteLine();
                    Console.WriteLine("Cliente Deletado com sucesso");

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é possível deletar o cliente porque há saldo em sua conta bancária.");
                }
            }

        }
    }
}