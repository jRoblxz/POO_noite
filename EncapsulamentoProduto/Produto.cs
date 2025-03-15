using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int codigo; //atributo
        private string nome = string.Empty; //atributo
        private double preco; //atributo
        public int Codigo //propriedade produto
        {
            get { return codigo; }
            set { 
                if (value > 0)
                    codigo = value; 
                else
                    System.Console.WriteLine("Codigo Inválido");
                }
        }
        public string Nome //propriedade Produto  
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        public double Preco //propriedade Produto
        {
            get { return preco; }
            set { preco = value; }
        }

        public void AdicionarProduto(int qtde){
            
        }
    }//class
}//namespace