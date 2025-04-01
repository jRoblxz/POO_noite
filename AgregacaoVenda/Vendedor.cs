using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; private set; }
        public void RegistrarVenda(double valorVenda)
        {
            Comissao += valorVenda * 0.02;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Comissão acumulada: {Comissao:c}");
        }
    }
}