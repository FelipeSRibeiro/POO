internal class Pratique
{
    private static void Main(string[] args)
    {
        /*Crie um programa que peça ao usuário para digitar um número inteiro e verifique se o número é par ou ímpar.
          Em seguida, imprima na tela uma mensagem informando o resultado*/
        
        int numero;

        Console.WriteLine("Digite um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é par");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ímpar");
        };

        /*Crie um programa que calcule a média de três notas informadas pelo usuário.
          Em seguida, imprima na tela a média calculada.*/

        double nota1;
        double nota2;
        double nota3;
        double media;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("A média final é: " + media);

        /*Crie um programa que peça ao usuário para digitar um número inteiro positivo e, em seguida, imprima todos os números pares
          entre 1 e o número informado.*/

        int numPositivo;

        Console.WriteLine("Digite um número positivo: ");
        numPositivo = Convert.ToInt32(Console.ReadLine());

        for (int x = 1; x <= numPositivo; x++)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
}