namespace Exercicio_notas_escola
{
    public class Aluno
    {
        private Prova Prova1 { get; set; }
        private Prova Prova2 { get; set; }

        public Aluno(Prova prova1, Prova prova2)
        {
            this.Prova1 = prova1;
            this.Prova2 = prova2;
        }

        public double MediaAluno()
        {
            return (Prova1.SomaNotas() + Prova2.SomaNotas()) / 2;
        }
    }
}