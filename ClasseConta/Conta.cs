using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declarar atributos (variaveis)
        public int numero;
        public string titular = string.Empty; //ou public string? titular;

        public double saldo;

        //declarar métodos/funções

        public void Sacar(double valorSaque)
        {
            this.saldo -= valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;

        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Numero: " + this.numero +
                            "\t Titular: " + this.titular +
                            "\t Saldo: " + this.saldo);

        }
        public void Transferir(double valorTransf, Conta objetoDestino) //conta é o tipo
        {
            saldo -= valorTransf; //c1
            objetoDestino.saldo += valorTransf; //c2
        }
    }
}