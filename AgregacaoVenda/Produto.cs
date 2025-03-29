using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public static int Codigo = 500;
        private string Nome;
        public string Nome
        {
            get { return Nome; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                    System.Console.WriteLine("Nome inválido");
                Nome = value; 
            }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set 
            { 
                if (value <= 0 )
                    System.Console.WriteLine("Valor Inválido");
                preco = value;
            }
        }
        
        public Produto(string nom, double pre)
        {
            Codigo += 1;
            Nome = Nome;
            Preco = pre;
            
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Preço {preco}");
        }

    }
}