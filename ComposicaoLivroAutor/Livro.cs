using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoLivroAutor
{
    public class Livro
    {
        public string? Titulo { get; set; }
        private int ano;
        public int Ano
        {
            get { return ano; }
            set 
            { 
                if(value > 2025) 
                {
                    System.Console.WriteLine("Ano invavlido");
                    return;
                }
                ano = value;
            }
        }
        
        public List<Autor> VetAutor { get; set; }

        public Livro(string titulo, int ano)
        {  
           Titulo = titulo;
           Ano = ano;
           VetAutor = new List<Autor>();
        }
        public void AdcionarAutor(Autor objetoAutor)
        {
            VetAutor.Add(objetoAutor);
        }
        public void ExibirDados()
        {
            System.Console.WriteLine($"Titulo: {Titulo} \nAno: {Ano}");
            foreach (Autor a in VetAutor)
            {
                a.ExibirDados();
            }
        }
        }


}
