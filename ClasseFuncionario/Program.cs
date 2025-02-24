using ClasseFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1;
        f1 = new Funcionario();
        f1.codigo = 101;
        f1.nome = "João";
        f1.salario = 199.9;
        f1.Exibir();
    }
}