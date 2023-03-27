using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class PrintPeopleList
    {
        public void PrintList()
        {
            Console.WriteLine("Lista de pessoas:\n-----------------");

            for(int i = 0; i < PeopleRepository.peopleRepository.Count; i++)
            {
                People person = PeopleRepository.peopleRepository[i];

                Console.WriteLine($"Id Pessoa: {person.Id}\nNome: {person.Name}\nTelefone: {person.Phone}\nId Cidade: {person.Citys.Id}\nCidade: {person.Citys.Name}\nEstado: {person.Citys.State}\nPaís: {person.Citys.Country}");
            }
        }
    }
}