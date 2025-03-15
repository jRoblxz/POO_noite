using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoVeiculo
{
    public class Veiculo
    {
        private int ano;
        private int quilometragem;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Quilometragem { get; set; }
        public int Ano
        {
            get { return ano; }
            set { 
                if (value >= 1900 && ano <= DateTime.Now.Year)
                    ano = value; 
                else
                    System.Console.WriteLine("Ano inválido!");
            }
        }
        
        
    }
}