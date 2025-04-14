using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerançaCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public void Mostrar(){
            base.Mostrar(); // chamr o metodo mostrar da classe base
            System.Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}