using Interface_animal.Interface;

namespace Interface_animal.TiposAnimais
{
    public class Gato : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
    }
}