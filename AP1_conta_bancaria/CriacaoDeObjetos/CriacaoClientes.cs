using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP1_conta_bancaria.Client;
using AP1_conta_bancaria.Captura;
using AP1_conta_bancaria.Contas;
using AP1_conta_bancaria.Repository;

namespace AP1_conta_bancaria.CriacaoDeObjetos
{
    public class CriacaoClientes
    {
        public void CiracaoClientes()
        {
            CapturaDeCliente capturaCliente = new CapturaDeCliente();
            capturaCliente.Captura();

            Cliente cliente = new Cliente(capturaCliente.Nome, capturaCliente.Endereco, capturaCliente.Cpf, null);
            
            CapturaContaBancaria capturaConta = new CapturaContaBancaria();
            capturaConta.capturaConta();

            ContaBancaria contaBancaria = new ContaBancaria(capturaConta.Numero, capturaConta.Saldo) { Cliente = cliente };
            new ContaBancariaRepository().AddContaBancaria(contaBancaria);

            cliente.ContaBancaria = contaBancaria;

            ClienteRepository repository = new ClienteRepository();
            repository.AddCliente(cliente);

            Console.WriteLine();
            Console.WriteLine("Cliente criado com sucesso. Nome do cliente: " + cliente.Nome);
            Console.WriteLine();
        }
    }
}