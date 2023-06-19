using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_biblioteca.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public User User { get; set; }
        public Author Author { get; set; }
    }
}