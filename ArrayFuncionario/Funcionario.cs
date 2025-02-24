using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome = string.Empty;
        public double salario;

        public void Exibir()
        {
            System.Console.WriteLine("Codigo: " + codigo +
                                    "\nNome: " + nome +
                                    "\nSalario: " + salario);
        }
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }       
    }
}