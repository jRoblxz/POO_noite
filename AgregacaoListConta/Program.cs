
using AgregacaoListConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli1 = new Cliente("João", 1234);
        Cliente cli2 = new Cliente("Pedro", 5678);

        Conta c1 = new Conta();
        c1.Numero = 101;
        c1.Saldo = 2000;
        c1.VetTitulares = new List<Cliente>();
        c1.VetTitulares.Add(cli1);
        c1.VetTitulares.Add(cli2);

        c1.ExibirDetalhes();
    }
}