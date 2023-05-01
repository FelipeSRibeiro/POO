using Interface_animal.Interface;

namespace Interface_animal.TiposAnimais
{
    public class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("Au au au");
        }
    }
}