using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public void Exibir()
        {
            System.Console.WriteLine("Codigo: " + codigo +
                                    "\nNome: " + nome +
                                    "\nSalario: " + salario);
        }       
    }
}