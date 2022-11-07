using ExemploExplorando.Models;
using System.Globalization;

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


decimal valorMonetario1 = 1054.23M;
decimal valorMonetario2 = 3365.98M;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-Br");
Console.WriteLine($"{valorMonetario1:C}");
Console.WriteLine(valorMonetario1.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{valorMonetario2:C}");