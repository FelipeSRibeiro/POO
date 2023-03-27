using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class CreatePeople
    {
        public void Create()
        {
            CapturePeople capture = new CapturePeople();
            capture.Capture();

            CaptureCity captureCity = new CaptureCity();
            captureCity.Capture();

            City city = new City(captureCity.Name, captureCity.State, captureCity.Country);
            new CityRepository().AddCity(city);

            People people = new People(capture.Name, capture.Phone, city);

            PeopleRepository pRepository = new PeopleRepository();
            pRepository.AddPeople(people);
        }
    }
}