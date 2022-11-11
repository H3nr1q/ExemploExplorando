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


//DICTIONARY
// Dictionary<string, string> estados = new();
// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("BA", "Bahia");

// Console.WriteLine(estados["RJ"]);

// foreach(KeyValuePair<string, string> item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("RJ");
// estados["BA"] = "Bahia o";

// foreach(KeyValuePair<string, string> item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando elemento: {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existe. Adicionar a chave {chave}");
// }

//TUPLA

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Henrique", "Silva", 1.80M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Fernanda", "Pondian", 1.70M);
// Console.WriteLine($"Id: {outroExemploTupla.Item1}");
// Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
// Console.WriteLine($"Altura: {outroExemploTupla.Item4}");


// var outroExemploTuplaCreate = Tuple.Create(3, "Clara", "Pondian", 1.05M);
// Console.WriteLine($"Id: {outroExemploTuplaCreate.Item1}");
// Console.WriteLine($"Nome: {outroExemploTuplaCreate.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
// Console.WriteLine($"Altura: {outroExemploTuplaCreate.Item4}");


// LeituraArquivo arquivo = new();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

// if(sucesso)
// {
//     // Console.WriteLine($"Quantidade de linhas {quantidadeLinhas}");

//     foreach(string linha in linhasArquivo){
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

//DESCONSTRUCTOR
// Pessoa p1 = new("Henrique", "Silva");
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// int numero = 20;
// bool ehPar = false;

// //IF Ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é {(ehPar ? "par" : "impar")}");


//IF normal
// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é inpar");
// }

//Serialização
using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVenda = new();

// Venda v1 = new(1, "Caneta", 1.00M, dataAtual);
// Venda v2 = new(2, "Caderno 1 Matéria", 7.50M, dataAtual);

// listaVenda.Add(v1);
// listaVenda.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

//Deserealizar

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}," +
                      $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}