using AgregacaoVenda;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p1 = new Produto("Nike", 50);
        Produto p2 = new Produto("Adidas", 100);

        p1.MostrarAtributos();
        p2.MostrarAtributos();

        Comprador c1 = new Comprador(500);
        Vendedor v1 = new Vendedor();

        c1.MostrarAtributos();
        v1.MostrarAtributos();
        
        Separador();
        
        Venda venda1 = new Venda(c1, v1);
        venda1.AdicionarProduto(p1);
        venda1.ExibirDetalhes();

        Separador();
        Venda venda2 = new Venda(c1, v1);
        venda2.AdicionarProduto(p2);
        venda2.ExibirDetalhes();

    }
    public static void Separador()
    {
        for (int i = 0; i < 50; i++)
        {
            System.Console.Write("=");
        }
        System.Console.WriteLine("");
    }
}