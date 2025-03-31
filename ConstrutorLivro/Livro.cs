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
        public int PaginasLidas
        {
            get { return paginasLidas; }
            set 
            { 
                if (value <= 0)
                    System.Console.WriteLine("Por gentileza informe uma data valida");
                paginasLidas = value; 
            }
        }
        public Livro(string titulo, int qntdPaginas)
        {
            Titulo = titulo;
            QntdPaginas = qntdPaginas;
        }
        public Livro(string titulo, string autor, int anoPublicacao, int qntdPaginas, int paginas_Lidas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            QntdPaginas = qntdPaginas;
            PaginasLidas = paginas_Lidas;
        }

       /* public void LerPaginas(int Paginas)
        {
            if (Paginas > 0 && Paginas < QntdPaginas - PaginasLidas) 
                PaginasLidas += Paginas;
            if (Paginas <= 0)
                System.Console.WriteLine("Digite um valor maior que 0");
            if (Paginas > QntdPaginas - PaginasLidas)
                System.Console.WriteLine("Numero de paginas lida maior que o numero de paginas");
        }*/

        public void LerPaginas(int paginas)
        {
            if (paginas <= 0)
            {
                Console.WriteLine("O número de páginas deve ser maior que zero.");
                return; 
            }
            if (PaginasLidas + paginas > QntdPaginas)
            {
                Console.WriteLine("O número de páginas lidas excedeu o total de páginas do livro.");
                return;
            }
            PaginasLidas += paginas;
            Console.WriteLine($"Você leu {paginas} páginas. Paginas restantes: {QntdPaginas - PaginasLidas}.");
        }
        public bool LivroConcluido ()
        {
            return QntdPaginas == PaginasLidas;
        }

        public void ExibirDetalhes()
        {
            System.Console.WriteLine($"Titulo: {Titulo} | Autor: {Autor} | Publicacao: {AnoPublicacao} | Paginas: {QntdPaginas} | Paginas Lidas: {PaginasLidas} | " + (LivroConcluido() ? "CONCLUIDO" : "NAO CONCLUIDO"));
        }

        

    }
}