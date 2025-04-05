using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoCursoAluno
{
    public class Curso
    {
        public string? NomeCurso { get; set; }
        public List<Aluno> VetAluno { get; set; }

        public Curso(string nomeCurso)
        {
            NomeCurso = nomeCurso;
        }
        
        public void AdicionarAluno(Aluno objetoAluno)
        {
            VetAluno.Add(objetoAluno);                          
        }
        public void ExibirDados()
        {
            System.Console.WriteLine("Nome do Curos: " + NomeCurso);
            foreach (Aluno a in VetAluno)
            {
                a.ExibirDados(); //classe aluno
            }
        }
    }
}