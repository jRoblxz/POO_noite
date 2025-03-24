using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
            
        }

        public void ExibirCliente()
        {
            System.Console.WriteLine($"Nome: {Nome} | Rg: {Rg}");
        }
    
    }
}