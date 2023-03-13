using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02_OO_basic
{
    public class Atividade_Aula_02
    {
        public static void Main(string[] args)
        {
            /*Crie uma classe chamada "Calculadora" que tenha dois métodos: "Somar" e "Subtrair". O método "Somar" deve receber
            dois números como parâmetros e retornar a soma desses números. O método "Subtrair" deve receber dois números como
            parâmetros e retornar a subtração desses números. Crie um objeto dessa classe e utilize os métodos para realizar
            operações matemáticas.*/

            double operando1, operando2;
            string operador;

            var calc = new Calculadora();

            Console.WriteLine("Digite o primeiro número:");
            operando1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            operando2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o operador (somar ou subtrair):");
            operador = Console.ReadLine();

            var resultado = calc.Calcular(operando1, operando2, operador);

            Console.WriteLine(resultado);
        }
    }
}