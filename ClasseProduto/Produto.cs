using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //definindo atributos
        public string nome_prod;
        public int qntd;
        public double preco;

        //definindo métodos
        public void AdicionarProduto(int qntd)
        {
            qntd += qntd;
        }
        public void RemoverProduto(int qntd)
        {
            qntd -= qntd;
        }
        public double ValorTotalEstoque()
        {
            return preco * qntd;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Nome: " + nome_prod + "\nQuantidade: " + qntd + "\nPreço: " + preco + "\nValor Total: " + ValorTotalEstoque());
        }


    }
}