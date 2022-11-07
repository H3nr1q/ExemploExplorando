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
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($"{aluno.NomeCompleto}");
            }
        }

    }
}