using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorLivro
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int QntdPaginas { get; set; }
        private int paginasLidas;
        public int PaginasLidas;
        {
            get { return paginasLidas; }
            set 
            { 
                if (value <= 0)
                    System.Console.WriteLine("Por gentileza informe uma data valida");
                paginasLidas = value; 
            }
        }
        public Livro(Parameters)
        {

        }
        public Livro(string Titulo, string Autor, int AnoPublicacao, int QntdPaginas, int PaginasLidas)
        {
            
        }
        

    }
}