using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoCursoAluno
{
    public class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set 
            { 
                if (value <= 0)
                {
                    System.Console.WriteLine("Numero de matricula invalido"); 
                    return;
                }
                matricula = value;
            }
        }
        
        public string? Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            this.Matricula = matricula;
            Nome = nome;
        }  

        public void ExibirDados()
        {
            System.Console.WriteLine($"Matricula: {Matricula} | Nome: {Nome}");
        }
    }
}