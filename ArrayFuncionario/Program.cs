using ArrayFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario[] vetF = new Funcionario[3];
        for(int i=0; i < vetF.Length; i++)
        {
        vetF[i] = new Funcionario(); //instância do objeto em cada posição
        Console.Write("Informe o código: ");
        vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o nome: ");
        vetF[i].nome = Convert.ToString(Console.ReadLine());
        Console.Write("Informe o salario: ");
        vetF[i].salario = Convert.ToDouble(Console.ReadLine());
        }
        foreach (Funcionario f in vetF)
        {
            f.Exibir();
            Separador();

        }  
    }
    private static void Separador()
    {
        for (int i = 0; i < 50; i++)
        {
            System.Console.Write("=");            
        }
        System.Console.Write("\n");
    }
}