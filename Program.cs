using ExemploExplorando.Models;
using System.Globalization;

// Pessoa p1 = new("Carlos", "Silva");
// Pessoa p2 = new("Henrique", "Silva");
// Pessoa p3 = new("Henrique", "Mariano");

// Curso cursoDeIngles = new();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionaAluno(p1);
// cursoDeIngles.AdicionaAluno(p2);
// cursoDeIngles.AdicionaAluno(p3);
// cursoDeIngles.ListarAlunos();
// cursoDeIngles.ObterQuantideAlunosMatriculados();

// cursoDeIngles.RemoveAluno(p3);
// cursoDeIngles.ListarAlunos();


// decimal valorMonetario1 = 1054.23M;
// decimal valorMonetario2 = 3365.98M;


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-Br");
// Console.WriteLine($"{valorMonetario1:C}");
// Console.WriteLine(valorMonetario1.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine($"{valorMonetario2:C}");


// double porcentagem = .3254;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 20221107;

// Console.WriteLine(numero.ToString("####-##-##"));

// DateTime data = DateTime.Now;
// int day = data.Day;

// Console.WriteLine($"{data}, {day} , {data.ToShortTimeString()}, {data.ToShortDateString()}");


// string dataString = "2022-07-170 18:00";

// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date2);
// Console.WriteLine(date2);

// DateTime date3 = DateTime.Parse(dataString);
// Console.WriteLine(date3);

// bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

// if (sucess)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {date}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/AArquivoLeitura.txt");

//     foreach(string linha in linhas){
//         Console.WriteLine(linha);
//     }  
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretório não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally{
//     Console.WriteLine("Chegou até aqui e finalizou!");
// }


// new ExemploExcecao().Metodo1();


// //Fila em C#
// Queue<int> fila = new();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// foreach(int item in fila){
//     Console.WriteLine(item);
// }

// //Remove 1º elemento da fila
// Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");

// foreach(int item in fila){
//     Console.WriteLine(item);
// }


// // Pilha no C#

// Stack<int> pilha = new();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);
// pilha.Push(12);

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo elemento: {pilha.Pop()}");

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }

Dictionary<string, string> estados = new();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");

Console.WriteLine(estados["RJ"]);

foreach(KeyValuePair<string, string> item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("RJ");
estados["BA"] = "Bahia o";

foreach(KeyValuePair<string, string> item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando elemento: {chave}");

if(estados.ContainsKey(chave)){
    Console.WriteLine($"Valor existente: {chave}");
}
else{
    Console.WriteLine($"Valor não existe. Adicionar a chave {chave}");
}



