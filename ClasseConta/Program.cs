using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        // declaração da variável
        Conta c1;

        //instanciação do objeto
        c1 = new Conta();

        //manipulação do objeto
        c1.numero = 101;
        c1.titular = "João";
        c1.saldo = 1000;
        //exibindo os valores do objeto
        c1.MostrarAtributos();
        //usando o método Sacar() e exibindo dados novamento
        double ValorSaque = 500;
        c1.Sacar(ValorSaque); //ValorSaque é um argumento
        //conta apos o saque
        c1.MostrarAtributos();

        Separador();

        Conta c2;
        c2 = new Conta();
        c2.numero = 102;
        c2.titular = "Pedro";
        c2.saldo = 1000;
        c2.MostrarAtributos();
        c2.Transferir(300,c1);

        Separador();
        c1.MostrarAtributos();
        c2.MostrarAtributos();

        c2.Depositar(100);

        Separador();
        c1.MostrarAtributos();
        c2.MostrarAtributos();
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