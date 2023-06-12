using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agenciaBancaria.Domain.Entities
{
    public class People
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public List<Account> Account {get; set; }
    }
}