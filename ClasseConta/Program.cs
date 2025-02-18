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
        objetoConta.saldo = 100;
        objetoConta.limite = 10;

        //exibindo os valores do objeto
        Console.WriteLine("Numero: " + objetoConta.numero);
        Console.WriteLine("Saldo: " + objetoConta.saldo);
        Console.WriteLine("Limite: " + objetoConta.limite);

        //declarar e instanciar objeto
        Conta c1 = new Conta();
        System.Console.Write("Qual o numero da conta?: ");
        c1.numero = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Qual o saldo da conta?: ");
        c1.saldo = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Qual o limite da conta?: ");
        c1.limite = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Numero: " + c1.numero);
        Console.WriteLine("Saldo: " + c1.saldo);
        Console.WriteLine("Limite: " + c1.limite);

        // instanciar classe funcionario

        Funcionario f1;

        f1 = new Funcionario();

        System.Console.Write("Qual o codigo do funcionario?: ");
        f1.codigo = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Qual o nome do funcionario?: ");
        f1.nome = Console.ReadLine();
        System.Console.Write("Qual o salario do funcionario?: ");
        f1.salario = Convert.ToDouble(Console.ReadLine());

        f1.MostrarAtributos();
        System.Console.WriteLine("Teste em casa");

    }
}