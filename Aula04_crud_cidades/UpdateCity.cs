using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class UpdateCity
    {
        private readonly PeopleRepository Repository;
        public UpdateCity()
        {
            Repository = new PeopleRepository();
        }

        public void Update()
        {
            Console.WriteLine("Digite o Id da cidade para editá-la");
            var update1 = Convert.ToInt32(Console.ReadLine());

            bool idExists = Repository.PeopleExists(update1);

            if (idExists)
            {
                var people = Repository.GetPeoplesList().FirstOrDefault(x => x.Id == update1);

                Console.WriteLine("Digite o novo nome de cidade");
                people.Citys.Name = Console.ReadLine();
                Console.WriteLine("Digite o novo nome de estado");
                people.Citys.State = Console.ReadLine();
                Console.WriteLine("Digite o novo nome Do Pais");
                people.Citys.Country = Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("A pessoa não foi encontrada na lista");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
            }
        }
    }
}