using EncapsulamentoEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante aluno1 = new Estudante();

        aluno1.Nome = "João";
        aluno1.Nota = 5;
        aluno1.ExibirInfos();
    }
}