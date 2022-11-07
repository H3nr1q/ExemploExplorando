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


double porcentagem = .3254;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 20221107;

Console.WriteLine(numero.ToString("####-##-##"));

DateTime data = DateTime.Now;
int day = data.Day;

Console.WriteLine($"{data}, {day} , {data.ToShortTimeString()}, {data.ToShortDateString()}");


string dataString = "2022-07-170 18:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date2);
Console.WriteLine(date2);

// DateTime date3 = DateTime.Parse(dataString);
// Console.WriteLine(date3);

bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

if (sucess)
{
    Console.WriteLine($"Conversão com sucesso! Data: {date}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}