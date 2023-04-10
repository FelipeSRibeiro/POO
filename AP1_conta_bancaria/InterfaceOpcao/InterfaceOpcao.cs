using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1_conta_bancaria.InterfaceOpcao
{
    public class InterfaceOpcao
    {
        public void interfaceUser()
        {
            Console.WriteLine();
            Console.WriteLine("Presione 1 para adicionar um cliente");
            Console.WriteLine("presione 2 para mostrar os clientes");
            Console.WriteLine("presione 3 para atualizar um cliente");
            Console.WriteLine("Presione 4 para excluir uma conta");
            Console.WriteLine("Presione 5 para Mostrar o extrato da sua conta");
            Console.WriteLine("Presione 6 para para sacar");
            Console.WriteLine("Presione 7 para trasferir");
            Console.WriteLine("Presione 0 para sair");
            Console.WriteLine();
        }
    }
}