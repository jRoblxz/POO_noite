using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerançaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string? nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void Mostrar()
        {
            System.Console.WriteLine("Codigo: " + Codigo +
                                    "\t Nome: " + Nome);
        }
        

    }
}