using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador comp { get; set; }
        public Vendedor vend { get; set; }
        public List<Produto> vetProd { get; set; }
        public Venda(Comprador comp1, Vendedor vend1)
        {
            comp = comp1;
            vend = vend1;
            vetProd = new List<Produto>();
        }

        public void AdicionarProduto(Produto prod1)
        {
            vetProd.Add(prod1);
            comp.Verba -= prod1.Preco;
            vend.RegistrarVenda(prod1.Preco);
        }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine("Detalhes venda: ");
            comp.MostrarAtributos();
            vend.MostrarAtributos();
            foreach (var prod in vetProd)
                prod.MostrarAtributos();
        }
        
    }

    
    }