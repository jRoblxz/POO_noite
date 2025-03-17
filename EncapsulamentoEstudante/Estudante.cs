using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private int nota;
        public string Nome { get; set; }
        public int Nota
        {
            get { return nota; }
            set { 
                if (value >= 0 && value <= 10)
                    nota = value;
                else
                    System.Console.WriteLine("Nota inválida");
                }
        }

        public bool EstaAprovado(int nota){
            return nota >= 6;
        }
        public void ExibirInfos()
        {
            System.Console.WriteLine("Nome: " + Nome + 
                                    "\nNota: " + Nota + 
                                    "\nStatus: " + EstaAprovado(Nota));
        }
        
    }
}