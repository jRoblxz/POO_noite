using HerançaCliente;
internal class Program
{
    private static void Main(string[] args)
    {
       Cliente c = new Cliente();
       c.Codigo = 1;
       c.Nome = "Ana";
       c.Mostrar();

       ClienteFisico cf = new ClienteFisico();
       cf.Rg = 100;
       cf.Codigo = 2;
       cf.Nome = "Bia";
       cf.Mostrar();

       ClienteJuridico cj = new ClienteJuridico();
       cj.Cnpj = 200;
       cj.Codigo = 3;
       cj.Nome = "Carnie";
       cj.Mostrar();
    }
}