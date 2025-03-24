using AgregacaoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli = new Cliente("João", 1234);
        Conta c1 = new Conta();
        c1.Numero = 101;
        c1.Saldo = 50;
        //objetoConta.abributo = objetoCliente
        c1.Titular = cli; //aqui efetiva a agregação

        Conta c2 = new Conta();
        c2.Numero = 202;
        c2.Saldo = 100;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Pedro";
        c2.Titular.Rg = 9876;

    }
}