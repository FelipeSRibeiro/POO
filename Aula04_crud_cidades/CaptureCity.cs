using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class CaptureCity
    {
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public void Capture()
        {
            System.Console.WriteLine("Digite o nome da cidade: ");
            this.Name = Console.ReadLine();

            System.Console.WriteLine("Digite o estado da cidade: ");
            this.State = Console.ReadLine();

            System.Console.WriteLine("Digite o país da cidade: ");
            this.Country = Console.ReadLine();
        }
    }
}