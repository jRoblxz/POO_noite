internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o ano de nascimento: ");
        int ano_nascimento = Convert.ToInt32(Console.ReadLine());
        int idade = 2025 - ano_nascimento;
        Console.WriteLine("Sua idade é " + idade + " anos");
    }
}