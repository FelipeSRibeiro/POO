// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Pratique o C#

/*Crie um programa que peça ao usuário para digitar um número inteiro e verifique se o número é par ou ímpar.
Em seguida, imprima na tela uma mensagem informando o resultado*/
/*
 int numero;

 Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
 
 if(numero % 2 == 0){
    Console.WriteLine("O número " + numero + " é par");
 }else{
    Console.WriteLine("O número " + numero + " é ímpar");
 };
*/
/*Crie um programa que calcule a média de três notas informadas pelo usuário.
 Em seguida, imprima na tela a média calculada.*/
/*
 double nota1, nota2, nota3, media;

 Console.WriteLine("Digite a primeira nota: ");
    nota1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Digite a segunda nota: ");
    nota2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Digite a terceira nota: ");
    nota3 = Convert.ToDouble(Console.ReadLine());

 media = (nota1 + nota2 + nota3) / 3;

 Console.WriteLine("A média final é: " + media);
*/
/*Crie um programa que peça ao usuário para digitar um número inteiro positivo e, em seguida, imprima todos os números pares
entre 1 e o número informado.*/
/*
int numPositivo;

Console.WriteLine("Digite um número positivo: ");
numPositivo = Convert.ToInt32(Console.ReadLine());

for(int x = 1; x <= numPositivo; x++){
    if(x % 2 == 0){
        Console.WriteLine(x);
    }
}
*/

// Atividade aula 02

using Aula02_OO_basic;

/*Crie uma classe chamada "Calculadora" que tenha dois métodos: "Somar" e "Subtrair". O método "Somar" deve receber
dois números como parâmetros e retornar a soma desses números. O método "Subtrair" deve receber dois números como
parâmetros e retornar a subtração desses números. Crie um objeto dessa classe e utilize os métodos para realizar
operações matemáticas.*/
/*
double operando1, operando2;
string operador;

var calc = new Aula02_OO_basic.Calculadora();

Console.WriteLine("Digite o primeiro número:");
operando1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
operando2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o operador (somar ou subtrair):");
operador = Console.ReadLine();

var resultado = calc.Calcular(operando1, operando2, operador);

Console.WriteLine("O resultado após " + operador + " é: " + resultado);
*/
/*Crie uma classe chamada "Pessoa" que tenha dois atributos: "Nome" e "Idade". Crie um método chamado "Apresentar" que imprima
na tela o nome e a idade da pessoa. Crie um objeto dessa classe e chame o método "Apresentar".*/
/*
Pessoa pessoa = new Pessoa();

pessoa.Nome = "Felipe";
pessoa.Idade = 41;

pessoa.Apresentar();
*/
/*Crie uma classe chamada "ContaBancaria" que tenha dois atributos: "Saldo" e "Numero". Crie dois métodos: "Depositar" e
"Sacar". O método "Depositar" deve receber um valor como parâmetro e acrescentar esse valor ao saldo da conta. O método "Sacar"
deve receber um valor como parâmetro e subtrair esse valor do saldo da conta, desde que haja saldo suficiente. Crie um objeto
dessa classe e utilize os métodos para realizar transações bancárias.*/



