using AP1_conta_bancaria.EstruturaInicial;
using AP1_conta_bancaria.InterfaceOpcao;
using AP1_conta_bancaria.AtualizarCliente;
using AP1_conta_bancaria.CriacaoDeObjetos;
using AP1_conta_bancaria.PrintListaClient;
using AP1_conta_bancaria.Repository;

BemVindo bemVindo = new BemVindo();
bemVindo.BemVindos();

InterfaceOpcao interfaceOpcao = new InterfaceOpcao();
interfaceOpcao.interfaceUser();

int _operator = Convert.ToInt32(Console.ReadLine());

while(_operator != 0)
{
    switch(_operator)
    {
        case 0:
            Environment.Exit(0);
            break;

        case 1:
            CriacaoClientes cliente = new CriacaoClientes();
            cliente.CiracaoClientes();
            break;

        case 2:
            PrintListCliente print = new PrintListCliente();
            print.PrintCliente();
            break;

        case 3:
            AtualizarCliente atualizarCliente = new AtualizarCliente();
            atualizarCliente.Atualizar();
            break;

        case 4:
            Console.WriteLine( );
            Console.WriteLine("Dige o Id para excluir a conta");
            var numeroConta = Convert.ToInt32(Console.ReadLine());
            ClienteRepository clienteDelete = new ClienteRepository();
            clienteDelete.DeletarCliente(numeroConta);
            break;

        case 5:
            Extrato extrato = new Extrato();
            extrato.ExtratoDaConta();
            break;

        case 6:
            Saque saque = new Saque();
            saque.Sacar();
            break;

        case 7:
            Transferir trasferir = new Transferir();
            trasferir.Transferencia();  
            break;
    } 

    interfaceOpcao.interfaceUser();

    _operator = Convert.ToInt32(Console.ReadLine());
}