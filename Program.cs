using ExemploExplorando.Models;

Pessoa p1 = new("Carlos", "Silva");
Pessoa p2 = new("Henrique", "Silva");
Pessoa p3 = new("Henrique", "Mariano");

Curso cursoDeIngles = new();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionaAluno(p1);
cursoDeIngles.AdicionaAluno(p2);
cursoDeIngles.AdicionaAluno(p3);
cursoDeIngles.ListarAlunos();
cursoDeIngles.ObterQuantideAlunosMatriculados();

cursoDeIngles.RemoveAluno(p3);
cursoDeIngles.ListarAlunos();
