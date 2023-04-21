namespace Exercicio_notas_escola
{
    public class Prova
    {
        private double Nota1 { get; set; }
        private double Nota2 { get; set; }

        public Prova( double nota1, double nota2)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }

        public double SomaNotas()
        {
            return Nota1 + Nota2;
        }
    }
}