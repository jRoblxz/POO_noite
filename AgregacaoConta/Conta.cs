using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        //Agregação acontecerá aqui
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirConta()
        {
            System.Console.WriteLine($"Numero: {Numero} | Titular: {Titular} | Saldo: {Saldo}");
        }
    }
}