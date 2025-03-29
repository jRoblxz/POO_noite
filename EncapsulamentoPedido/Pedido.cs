using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoPedido
{
    public class Pedido
    {
        //atributos
        private int numPedido;
        public List<string> VetItens { get; set; } = new List<string>();
        public decimal Valor { get; set; }

        //construtor
        public Pedido(int num_Pedido)
        {
            numPedido = num_Pedido;
            Valor = 0;
        }
        //encapsulamento + validação
        public int NumPedido
        {
            get { return numPedido; }
            set 
            { 
                if (value <= 0)
                    System.Console.WriteLine("Numero do pedido não pode ser igua a 0");
                numPedido = value; }
        }

        //Metodos
        public void AdicionarItens(string nomeItem, decimal preco)
        {
            if (string.IsNullOrEmpty(nomeItem))
            {
                System.Console.WriteLine("Nome não pode ser vazio");
                return;
            }
            if (preco <= 0)
            {
                System.Console.WriteLine("Valor não pode ser igual ou menor que 0");
            }
            VetItens.Add($"{nomeItem} = {preco:c}");
            Valor += preco;
        }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Detalhes do pedido: {NumPedido}");
            foreach (var item in VetItens)        
                System.Console.WriteLine($"Item: {item}");  
            System.Console.WriteLine($"Valor Total: {Valor:c}");
        }
    }
}
