using Aula04_crud_cidades;

int _options;

do
{
    InterfaceOptions interfaceOptions = new InterfaceOptions();
    interfaceOptions.interfaceUser();

    _options = Convert.ToInt32(Console.ReadLine());  

    switch(_options)
    {
        case 0:
            Environment.Exit(0);
            break;

        case 1:
            CreatePeople createPeople = new CreatePeople();
            createPeople.Create();
            break;

        case 2:
            PrintPeopleList printPeopleList = new PrintPeopleList();
            printPeopleList.PrintList();
            break;

        case 3:
            UpdatePeople updatePeople = new UpdatePeople();
            updatePeople.Update();
            break;

        case 4:
            Console.WriteLine("Digite o Id da pessoa para excluí-la");
            int id = Convert.ToInt32(Console.ReadLine());
            PeopleRepository repository = new PeopleRepository();
            repository.DeletePeople(id);
            break;
        
        case 5:
            new UpdateCity().Update();
            break;

        case 6:
            Console.WriteLine("Digite o Id da cidade para excluí-la");
            var idCity = Convert.ToInt32(Console.ReadLine());
            CityRepository repositoryCity = new CityRepository();
            repositoryCity.DeleteCity(idCity);
            break;
    }
}
while(_options != 0);
