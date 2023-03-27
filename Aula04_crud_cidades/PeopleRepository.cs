using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class PeopleRepository
    {
        public static List<People> peopleRepository = new List<People>();

        public void AddPeople(People people)
        {
            peopleRepository.Add(people);
        }

        public List<People> GetPeoplesList()
        {
            return peopleRepository;
        }

        public void updatePeople(int peopleId, People updatePerson)
        {
            People personToUpdate = peopleRepository.FirstOrDefault(p => p.Id == peopleId);
            
            if(personToUpdate != null)
            {
                personToUpdate.Name = updatePerson.Name;
                personToUpdate.Phone = updatePerson.Phone;
            }
            
        }

        public bool PeopleExists(int personId)
        {
            return peopleRepository.Any(p => p.Id == personId);
        }

        public void DeletePeople(int personId)
        {
            People peopleToRemove = peopleRepository.FirstOrDefault(p => p.Id == personId);

            if(peopleToRemove != null)
            {
                peopleRepository.Remove(peopleToRemove);
            }
        }

        public void RemoveCity(int idCity)
        {
            foreach (var item in peopleRepository)
            {
                if (item.Citys.Id == idCity)
                {
                    item.Citys = new City();
                }
            }
        }
    }
}