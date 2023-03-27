using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_crud_pessoas
{
    public class CreatePeople
    {
        public void Create()
        {
            CapturePeople capture = new CapturePeople();
            capture.Capture();

            People people = new People(capture.Name, capture.Phone);

            PeopleRepository pRepository = new PeopleRepository();
            pRepository.AddPeople(people);
        }
    }
}