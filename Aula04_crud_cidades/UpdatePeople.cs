using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class UpdatePeople
    {
        public void Update()
        {
            PeopleRepository repositoryExisting = new PeopleRepository();
            
            Console.WriteLine("Digite o Id da pessoa para editar");
            var update1 = Convert.ToInt32(Console.ReadLine());

            bool idExisting = repositoryExisting.PeopleExists(update1);

            if(idExisting)
            {
                var people = repositoryExisting.GetPeoplesList().FirstOrDefault(x => x.Id == update1);

                Console.WriteLine("Digite um novo nome:");
                people.Name = Console.ReadLine();

                Console.WriteLine("Digite um novo telefone");
                people.Phone = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n-------------------------------------\nA pessoa não foi encontrada na lista!\n-------------------------------------\n");
            }
        }
    }
}