using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        //estabelecendo a composição
        //essa é a classe que tem o losango//diamante
        //a notaFiscal é composta por ItemNotaFiscal
        public List<ItemNotaFiscal> VetItemNf { get; set; }
        public NotaFiscal(int numeroNF, string data)
        {//aqui é a representação da composição
            NumeroNf = numeroNF;
            Data = data;
            VetItemNf = new List<ItemNotaFiscal>();
        }
        public void AdicionarItens(ItemNotaFiscal item)
        {
            VetItemNf.Add(item);
        }
        public void Mostrar()
        {
            System.Console.WriteLine($"Número da Nota Fiscal: {NumeroNf}");
            System.Console.WriteLine($"Data da Compra: {Data}");
            foreach (var item in VetItemNf)
            {                
                System.Console.WriteLine($"Qtde item: {item.Qtde}");
            }
        }
        ~NotaFiscal()//Destrutor
        {
            VetItemNf = null;
            System.Console.WriteLine("Destrutor Nota Fiscal");
        }
    }
}