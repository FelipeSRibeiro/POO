﻿using Aula13_repository;

Person person = new Person("Edilson", 27);

Person person2 = new Person("JR",20);
Person person3= new Person { Nome = "Scheila", Idade=22};
Person person4= new Person { Nome = "Lucas", Idade=35}; 
Person person5 = new Person("bernardo",23);

List<Person> Persons = new List<Person>();

Persons.Add(person);
Persons.Add(person2);
Persons.Add(person3);
Persons.Add(person4);
Persons.Add(person5);

foreach (var p in Persons)
{
    Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");
}

Console.WriteLine("Digite 1-Criar Person\n2-Alterar\n0-Sair");

int operador = Convert.ToInt32(Console.ReadLine());
while(operador !=0)
{
    switch (operador)
    {
        case 1:
            Criar();
            break;
        case 2:
            Console.WriteLine("chamar function alterar");
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Selecioe uma das opções.");
            break;
    }
}



void Criar()
{
    PersonRepository repository = new PersonRepository();


    City city = new City(1,"torres");
    Person obj  = new Person("Joao", 40, city);


    // o joao mora em Torres

    Console.WriteLine($"o {obj.Nome} mora em {obj.City.Nome}")


    Console.WriteLine("vamos criar uma Person,\npedir os dados e adicionar na lista");


} 
