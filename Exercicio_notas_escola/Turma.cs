using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_notas_escola
{
    public class Turma
    {
        private Aluno Aluno1 { get; set; }
        private Aluno Aluno2 { get; set; }
        private Aluno Aluno3 { get; set; }

        public Turma(Aluno aluno1, Aluno aluno2, Aluno aluno3)
        {
            this.Aluno1 = aluno1;
            this.Aluno2 = aluno2;
            this.Aluno3 = aluno3;
        }

        public double MediaTurma()
        {
            return (Aluno1.MediaAluno() + Aluno2.MediaAluno() + Aluno3.MediaAluno()) / 3;
        }
    }
}