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

        public bool EstaAprovado(){
            return nota >= 6;;
        }
        public void ExibirInfos()
        {
            Console.WriteLine("Nome: " + Nome +
                              "\tNota: " + Nota +           //se for true   se for false
                              "\tStatus: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }
        
    }
}