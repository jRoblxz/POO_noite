using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContrutorConta
{
    public class Conta
    {
        public int Numero { get; set; } //propriedade
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public bool Situacao { get; set; }
        public static int Contador { get; set; }
        public Conta() //new Conta();
        {//contrutor padrão
            Contador++;
        }
        public Conta(int numero){ //new Conta(11);
            //Propriedade/atributo   = parametro
            Numero = numero;
            Contador++;
        }
        public Conta(int numero, string nome){ //new Conta(12, Joao);
            //Propriedade/atributo   = parametro
            Numero = numero;
            Titular = nome;
            Contador++;
        }
        public void ExibirDetalhes(){
            System.Console.WriteLine($"Número: {Numero} \tTitular: {Titular} \tSaldo: {Saldo:c} \t Situação {Situacao}");
        }
    }
}