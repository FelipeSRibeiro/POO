using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class CapturePeople
    {
        public String Name { get; set; }
        public String Phone { get; set; }

        public void Capture()
        {
            System.Console.WriteLine("Digite o nome: ");
            this.Name = Console.ReadLine();
            System.Console.WriteLine("Digite o telefone: ");
            this.Phone = Console.ReadLine();
        }
    }
}