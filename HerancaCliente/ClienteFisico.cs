using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{// sublasse / Classe derivada : classe base/superclasse
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public void Mostrar()
        {
            Console.WriteLine("Rg: " + Rg);
        }
        public ClienteFisico(int codigo, string nome, int rg) : base(codigo,nome)
        {
           Rg = rg;
        }
        public ClienteFisico()
        {            
        }

    }
}