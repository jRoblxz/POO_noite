using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        // declaração da variável
        Conta objetoConta;

        //instanciação do objeto
        objetoConta = new Conta();

        //manipulação do objeto
        objetoConta.numero = 101;
        objetoConta.titular = "João";
        objetoConta.saldo = 1000;
        //exibindo os valores do objeto
        objetoConta.MostrarAtributos();
        //usando o método Sacar() e exibindo dados novamento
        double ValorSaque = 500;
        objetoConta.Sacar(ValorSaque); //ValorSaque é um argumento
        objetoConta.MostrarAtributos();
        Separador();
/*
        //declarar e instanciar objeto
        Conta c1 = new Conta();
        System.Console.Write("Qual o numero da conta?: ");
        c1.numero = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Qual o Titular da conta?: ");
        c1.titular = Console.ReadLine();
        System.Console.Write("Qual o Saldo da conta?: ");
        c1.saldo = Convert.ToDouble(Console.ReadLine());
        c1.MostrarAtributos();
        System.Console.WriteLine("Você quer sacar dinheiro? S/N: ");
        string op = Console.ReadLine();

        if (op == "S")
        {
            System.Console.WriteLine("Qual o valor? ");
            double ValorSaque2 = Convert.ToDouble(Console.ReadLine());
            c1.Sacar(ValorSaque2);
            c1.MostrarAtributos();
        }
        System.Console.WriteLine("\n =================== \n");*/
        System.Console.WriteLine("\n");
        Conta c2 = new Conta();
        c2.MostrarAtributos();
        c2.Depositar(200);
        c2.MostrarAtributos();

    }
    private static void Separador()
    {
        for (int i = 0; i < 30; i++)
        {
            System.Console.Write("=");            
        }
    }
}