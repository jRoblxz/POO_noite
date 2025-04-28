using PolimorfismoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario(1, "Joao", 100);
        System.Console.WriteLine($"Bonificação: {f.CalcularBonificacao():c}");

        Secretario s = new Secretario(2, "Pedro", 100);
        System.Console.WriteLine($"Bonificação: {s.CalcularBonificacao():c}");

        Gerente g = new Gerente(3, "Costa", 100);
        System.Console.WriteLine($"Bonificação: {g.CalcularBonificacao():c}");

        Diretor d = new Diretor(4, "Roblez", 100);
        System.Console.WriteLine($"Bonificação: {d.CalcularBonificacao():c}");
    }
}
