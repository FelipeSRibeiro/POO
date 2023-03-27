using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04_crud_cidades
{
    public class CreateCity
    {
        public void Create()
        {
            CaptureCity capture = new CaptureCity();
            capture.Capture();

            City city = new City(capture.Name, capture.State, capture.Country);

            CityRepository repository = new CityRepository();
            repository.AddCity(city);
        }
    }
}