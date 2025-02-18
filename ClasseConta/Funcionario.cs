using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Funcionario
    {
        //atributos
        public int codigo;
        public string nome;
        public double salario;

        //metodos
        public void MostrarAtributos(){
            System.Console.WriteLine("Código: " + codigo);
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Salario: " + salario);

        }

    }
}