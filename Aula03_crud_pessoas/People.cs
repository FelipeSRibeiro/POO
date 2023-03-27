using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class People
    {
        private static int generateId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public People(string name, string phone)
        {
            this.Id = generateId;
            generateId++;
            this.Name = name;
            this.Phone = phone;
        }

    }
}