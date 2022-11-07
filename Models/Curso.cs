using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionaAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantideAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoveAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            int quantidade = ObterQuantideAlunosMatriculados();
            Console.WriteLine($"{quantidade} alunos matriculados no curso de {Nome}!");
            Console.WriteLine("Listagem usando concatenação");
            for(int count = 0; count < Alunos.Count; count++){
                //contatenação de string
                int sequencia = count+1;
                string texto = "Nº " + sequencia + " - " +Alunos[count].NomeCompleto;
                Console.WriteLine(texto);   
            }
            Console.WriteLine("Listagem usando interpolação");
            for(int count = 0; count < Alunos.Count; count++){
                //interpolação de string
                int sequencia2 = count+1;
                string texto2 = $"Nº {sequencia2} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto2);
            }
        }
    }
}