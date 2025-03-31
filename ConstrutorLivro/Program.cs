using ConstrutorLivro;
internal class Program
{
    private static void Main(string[] args)
    {
        Livro liv1 = new Livro("C# POO", "Joao", 2025, 30, 15);
        liv1.ExibirDetalhes();
        liv1.LerPaginas(15);
        liv1.ExibirDetalhes();

        Separador();

        Livro liv2 = new Livro("Python", 50);
        liv2.ExibirDetalhes();
        liv2.Autor = "Pedro";
        liv2.AnoPublicacao = 2023;
        liv2.LerPaginas(20); // lendo 20 paginas
        liv2.ExibirDetalhes();
        liv2.LerPaginas(31); // testando o metodo para valores maior que o numero de paginas do objeto
        liv2.ExibirDetalhes();
        liv2.LerPaginas(0); // testando o metodo para valores 0 
        liv2.ExibirDetalhes();
        liv2.LerPaginas(25); // testando o metodo com valor correto
        liv2.ExibirDetalhes();
        liv2.LerPaginas(5); // adicionando o restante de paginas para o metodo Livro Concluido funcionar
        liv2.ExibirDetalhes();
    }

    static void Separador()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.Write("=");
        }
        System.Console.WriteLine("");
    }
}