using ComposicaoLivroAutor;
internal class Program
{
    private static void Main(string[] args)
    {
        Autor autor1 = new Autor("Joao", "Brasileiro");
        Autor autor2 = new Autor("Carine", "Coreana");
        Autor autor3 = new Autor("Miguel", "Japones");


        Livro livro1 = new Livro("Fatec ADS", 1989);
        livro1.AdcionarAutor(autor1);
        livro1.AdcionarAutor(autor2);
        livro1.ExibirDados();
        Separador();
        Livro livro2 = new Livro("Futebol", 2003); 
        livro2.AdcionarAutor(autor1);
        livro2.AdcionarAutor(autor3);
        livro2.ExibirDados();
        Separador();
        Livro livro3 = new Livro("Familia", 2026); 
        livro3.AdcionarAutor(autor1);
        livro3.AdcionarAutor(autor2);
        livro3.AdcionarAutor(autor3);
        livro3.ExibirDados();        
    }
    private static void Separador()
    {
        for (int i = 0; i < 50; i++)
        {
            System.Console.Write("=");            
        }
        System.Console.Write("\n");
    }
}