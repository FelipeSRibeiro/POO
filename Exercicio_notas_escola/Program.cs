using Exercicio_notas_escola;

Prova prova1 = new Prova(4.0, 2.5);
Prova prova2 = new Prova(1.0, 7.0);
Aluno aluno1 = new Aluno(prova1, prova2);
Console.WriteLine("\nMédia aluno 1: " + aluno1.MediaAluno() + "\n");

prova1 = new Prova(6.5, 3.5);
prova2 = new Prova(0.0, 3.0);
Aluno aluno2 = new Aluno(prova1, prova2);
Console.WriteLine("Média aluno 2: " + aluno2.MediaAluno() + "\n");

prova1 = new Prova(5.0, 4.0);
prova2 = new Prova(6.0, 1.5);
Aluno aluno3 = new Aluno(prova1, prova2);
Console.WriteLine("Média aluno 3: " + aluno3.MediaAluno() + "\n");

Turma turma = new Turma(aluno1, aluno2, aluno3);

Console.WriteLine($"Média Turma: {turma.MediaTurma()}\n");