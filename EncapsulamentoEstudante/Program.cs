using EncapsulamentoEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante aluno1 = new Estudante();
        aluno1.Nome = "João";
        aluno1.Nota = 5;
        aluno1.ExibirInfos();

        Estudante aluno2 = new Estudante();
        aluno2.Nome = "Pedro";
        aluno2.Nota = 6;
        aluno2.ExibirInfos();

    }
}