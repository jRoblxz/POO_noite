using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoListConta
{
    public class Conta
    {
        public int Numero { get; set; }
        //Agregação acontecerá aqui
        public List<Cliente> VetTitulares { get; set; } //= new List<Clinte>();
        public double Saldo { get; set; }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Numero: {Numero} | Saldo: {Saldo:c}");
            foreach (Cliente c in VetTitulares)
                c.ExibirDetalhes();
        }
    }
}