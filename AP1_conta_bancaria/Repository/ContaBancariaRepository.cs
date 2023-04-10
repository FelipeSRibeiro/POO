using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP1_conta_bancaria.Contas;

namespace AP1_conta_bancaria.Repository
{
    public class ContaBancariaRepository
    {
        public static List<ContaBancaria> contasBancarias = new List<ContaBancaria>();

        public void AddContaBancaria(ContaBancaria conta)
        {
            contasBancarias.Add(conta);
        }

        public ContaBancaria ProcurarContaBancaria(string numeroConta)
        {
            return contasBancarias.FirstOrDefault(conta => conta.Numero == numeroConta);
        }

        public List<ContaBancaria> GetContasBancarias()
        {
            return contasBancarias;
        }
    }
}