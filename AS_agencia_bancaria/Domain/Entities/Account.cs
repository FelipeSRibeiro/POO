using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agenciaBancaria.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }

        public string NamberAccount { get; set; }

        public string AgencyNumber { get; set; }

        public People People {get; set;}

        
    }
}