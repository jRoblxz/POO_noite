using ConstrutorFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.ExibirDetalhes();

        Funcionario f2 = new Funcionario(20);
        f2.ExibirDetalhes();
        
        Funcionario f3 = new Funcionario(30, "João", 2300);
        f3.ExibirDetalhes();

        System.Console.WriteLine("Qtde de instâncias:" + Funcionario.Cont);
    }
}