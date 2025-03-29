using EncapsulamentoPedido;
internal class Program
{
    private static void Main(string[] args)
    {
        //primeira instancia
        Pedido pedido1 = new Pedido(1);
        pedido1.AdicionarItens("Camiseta", 49.99m);
        pedido1.AdicionarItens("Calça Jeans", 99.90m);
        pedido1.ExibirDetalhes();

        System.Console.WriteLine("\n");

        //segunda instancia
        Pedido pedido2 = new Pedido(2);
        pedido2.AdicionarItens("Tênis", 129.99m);
        pedido2.AdicionarItens("Boné", 35.50m);
        pedido2.ExibirDetalhes();
    }
}