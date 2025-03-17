using ContrutorConta; //namespace
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta(); //Conta() --> construtor, ele inicializa os atributos do objeto
        c1.ExibirDetalhes();
        Conta c2 = new Conta(1);
        c2.ExibirDetalhes();
        Conta c3 = new Conta(12, "João");
        c3.Saldo = 10000;
        c3.ExibirDetalhes();
        System.Console.WriteLine("Qtde de Contrutores: " + Conta.Contador); //quem chama um atributo static é a classe (Conta)
    }
}