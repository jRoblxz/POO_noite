using PolimorfismoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {

        Funcionario f = new Funcionario(1, "Joao", 100);
        Secretario s = new Secretario(2, "Pedro", 150);
        Gerente g = new Gerente(3, "Costa", 200);
        Diretor d = new Diretor(4, "Roblez", 300);

        GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

        gerenciador.TotalizadorBonificacao(f);
        gerenciador.TotalizadorBonificacao(s);
        gerenciador.TotalizadorBonificacao(g);
        gerenciador.TotalizadorBonificacao(d);

        Console.WriteLine($"Bonificação Funcionário: {f.CalcularBonificacao():c}");
        Console.WriteLine($"Bonificação Secretário: {s.CalcularBonificacao():c}");
        Console.WriteLine($"Bonificação Gerente: {g.CalcularBonificacao():c}");
        Console.WriteLine($"Bonificação Diretor: {d.CalcularBonificacao():c}");
        Console.WriteLine($"\nTotal de Bonificações: {gerenciador.TotalBonificacao:c}");
    }
}
