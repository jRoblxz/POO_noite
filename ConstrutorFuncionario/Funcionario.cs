using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //Declaração dos Atributos
        //
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public static int Cont { get; private set; }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Matrícula: {Matricula} | Nome: {Nome} | Salário: {Salario:c}");
        }

        static Funcionario() // Construtor padrão
        {
            Cont = 100;
        }
        public Funcionario(int matricula)
        {
            Matricula = matricula;
            Cont++;

        }
        public Funcionario(int matricula, string nome, decimal salario)
        {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
            Cont++;
        }
    }
}