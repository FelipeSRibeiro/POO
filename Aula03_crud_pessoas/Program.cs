﻿using Aula03_crud_pessoas;

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
            Console.WriteLine("Digite o Id da pessoa para excluir");
            int id = Convert.ToInt32(Console.ReadLine());
            PeopleRepository repository = new PeopleRepository();
            repository.DeletePeople(id);
            break;
    }
}
while(_options != 0);
