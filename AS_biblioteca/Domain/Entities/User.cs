using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_biblioteca.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public List<Book> Book { get; set;}
    }
}