// See https://aka.ms/new-console-template for more information
using agenciaBancaria.Data.Context;
using agenciaBancaria.Domain.Entities;
using agenciaBancaria.Domain.Interfaces;
using agenciaBancaria.Domain.Repositories;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine(" Presione 1 para adicionar um cliente");
        Console.WriteLine(" Presione 2 para mostrar os clientes ");
        Console.WriteLine(" Presione 3 para atualizar um cliente");
        Console.WriteLine(" Presione 4 para criar um conta");
        Console.WriteLine(" Presione 5 para excluir um cliente");
        Console.WriteLine(" Presione 6 para excluir uma conta");
        Console.WriteLine(" Presione 0 para sair");
        Console.WriteLine();

        var db = new DataContext();
        IPeopleRepository _people = new PeopleRepository(db);
        IAccountRepository _account = new AccountRepository(db);

        int _operator = Convert.ToInt32(Console.ReadLine());
        while (_operator != 0)
        {
            switch(_operator)
            {
                case 0: 
                    Environment.Exit(0);
                    break;
                case 1:
                    System.Console.WriteLine("Digite seu nome");
                    string nome = Console.ReadLine();
                    System.Console.WriteLine("Digite seu CPF");
                    string cpf = Console.ReadLine();
                     var people = new People(){Nome = nome, Cpf = cpf};
                     _people.Save(people);
                    break;
                case 2:
                    GetAllPEople();
                    break;
                case 3:
                    System.Console.WriteLine("Digite um id para atualizar o nome");
                    int id = Convert.ToInt32(Console.ReadLine()); 
                    var existCliente = _people.GetById(id);
                    if(existCliente != null)
                    {
                        System.Console.WriteLine("Digite o nome do novo cliente");
                        string newName = Console.ReadLine();

                        existCliente.Nome = newName;
                        _people.Update(existCliente);

                        System.Console.WriteLine("Nome alterado com sucesso");
                        
                    }
                    else
                    {
                        System.Console.WriteLine("Cliente não encontrado");
                    }
                    break;
                case 4:
                    System.Console.WriteLine("Digite um id para criar a conta do cliente");
                    string idAccount = Console.ReadLine();
                    System.Console.WriteLine("Digite um numero da conta");
                    string numberAccount = Console.ReadLine();
                    System.Console.WriteLine("Digite um numero da agencia");
                    string numberAgencia = Console.ReadLine();
                    var account = new Account(){ NamberAccount = numberAccount, AgencyNumber = numberAgencia};
                    _account.Save(account,idAccount);
                    break;
                case 5:
                     System.Console.WriteLine("Digite um id para excluir");
                     int idDelete = Convert.ToInt32(Console.ReadLine());
                     _people.Delete(idDelete);

                    break;
                case 6:
                    System.Console.WriteLine("Digite um id para excluir uma conta");
                     int idDeleteAccount = Convert.ToInt32(Console.ReadLine());
                     _account.Delete(idDeleteAccount);
                    break;
            }
            _operator = Convert.ToInt32(Console.ReadLine());
        }
       
        void GetAllPEople()
        {
        System.Console.WriteLine("Pessoas");

        var people = _people.GetAll();
        foreach (var person in people)
        {
            System.Console.WriteLine($"Id: {person.Id} | Nome: {person.Nome} | CPF: {person.Cpf}");

            if (person.Account != null && person.Account.Count > 0)
            {
                System.Console.WriteLine("Contas:");

                foreach (var account in person.Account)
                {
                    System.Console.WriteLine($"- ID: {account.Id} | - Número da conta: {account.NamberAccount} | Número da agência: {account.AgencyNumber}");
                }
            }
            else
            {
                System.Console.WriteLine("Sem conta vinculada.");
            }
            
            System.Console.WriteLine();
            }
        }

    }
}