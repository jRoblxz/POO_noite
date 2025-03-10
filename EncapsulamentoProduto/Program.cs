using EncapsulamentoProduto; //namespace
internal class Program
{
    private static void Main(string[] args)
    {
        //tipo
        //Classe   //objeto   //alocação de memoria    //Construtor
        Produto    p1 =        new                      Produto();
        p1.Codigo = 1; //Vai utilizar o set para alocar na variavel codigo dentro da classe
        p1.Nome = "Teclado"; //set
        System.Console.WriteLine("Nome do produto: " + p1.Nome); //get

        Produto p2 = new Produto();
        p2.Codigo = 2; //set
        p2.Nome = "Mouse"; //set
        p2.Preco = 55.90; //set
        System.Console.WriteLine("Código do produto: " + p2.Codigo); //get
        System.Console.WriteLine("Nome do produto: " + p2.Nome); //get
        System.Console.WriteLine("Preço do produto: " + p2.Preco); //get
        
    }
}