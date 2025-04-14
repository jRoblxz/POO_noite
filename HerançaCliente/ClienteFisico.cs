using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerançaCliente
{//   subclasse/classe derivada : classe base/superclasse
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public int Codigo { get; set; }
        public string? Nome { get; set; }

        public void Mostrar(){
            System.Console.WriteLine("RG: " + Rg);
        }
    }
}