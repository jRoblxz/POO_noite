using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoCursoAluno
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string? Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }  

        public void ExibirDados()
        {
            System.Console.WriteLine($"Matricula: {Matricula} | Nome: {Nome}");
        }
    }
}