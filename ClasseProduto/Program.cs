using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p1;
        p1 = new Produto();
        p1.nome_prod = "Nike";
        p1.qntd = 2;
        p1.preco = 99.9;
        p1.MostrarAtributos();

        Produto p2;
        p2 = new Produto();
        Console.Write("Escolha o nome do produto: ");
        p2.nome_prod = Console.ReadLine();
        Console.Write("Qual a quantidade? ");
        p2.qntd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Qual a preco? ");
        p2.preco = Convert.ToDouble(Console.ReadLine());
        p2.MostrarAtributos();


    /*
        do
        {
            int = op;

            System.Console.WriteLine("Escolha uma opção: ");
            System.Console.WriteLine("1- Adicionar Produto");
            System.Console.WriteLine("2- Remover Produto");
            System.Console.WriteLine("3- Ver atributos de um produto");
            op = Console.ToInt32.Readline();

            switch (op)
            {
                case 1:
                    p2

                
                default:
            }

        } while (int != 4);

        */
        

    }
}