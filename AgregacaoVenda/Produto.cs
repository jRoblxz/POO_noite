using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; private set; }
        private static int contCodigo = 500;
        private string nome;
        private double preco;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set 
            { 
                if (value <= 0 )
                    System.Console.WriteLine("Valor Inválido");
                else 
                    preco = value;
            }
        }
        public Produto(string nom, double pre)
        {
            Codigo = contCodigo++;
            Nome = nom;
            Preco = pre;
            
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Preço {preco}");
        }

    }
}