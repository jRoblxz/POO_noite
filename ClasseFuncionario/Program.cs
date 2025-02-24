using ClasseFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1;
        f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "João";
        f1.salario = 1000;
        f1.Exibir();
        f1.CalcularAumento(3.5);
        System.Console.WriteLine("Novo salario: " +f1.salario);
    }
}