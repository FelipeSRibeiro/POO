using Interface_animal.Interface;

namespace Interface_animal.TiposAnimais
{
    public class Papagaio : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Currupaco");
        }
    }
}