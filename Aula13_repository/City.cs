namespace Aula13_repository
{
    public class City
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public City(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}