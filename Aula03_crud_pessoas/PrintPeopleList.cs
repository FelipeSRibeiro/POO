using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class PrintPeopleList
    {
        public void PrintList()
        {
            Console.WriteLine("Lista de pessoas:\n-----------------");

            for(int i = 0; i < PeopleRepository.peopleRepository.Count; i++)
            {
                People person = PeopleRepository.peopleRepository[i];

                Console.WriteLine($"Id: {person.Id}\nNome: {person.Name}\nTelefone: {person.Phone}");
            }
        }
    }
}