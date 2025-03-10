using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int codigo; //atributo
        public int Codigo //propriedade 
        {
            get { return codigo; }
            set { 
                if (value > 0)
                    codigo = value; 
                else
                    System.Console.WriteLine("Codigo Inválido");
                }
        }
        private string nome = string.Empty; //atributo
        public string Nome //propriedade Produto  
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        private double preco; //atributo
        public double Preco //propriedade Produto
        {
            get { return preco; }
            set { preco = value; }
        }
    }//class
}//namespace