using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoListConta
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

        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Nome: {Nome} | RG: {Rg}");
        }
    
    }
}