using AgregacaoCursoAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno(101, "Carine");
        Aluno aluno2 = new Aluno(102, "Joao");

        Curso c1 = new Curso("ADS");
        c1.VetAluno = new List<Aluno>();
        c1.AdicionarAluno(aluno1);
        c1.AdicionarAluno(aluno2);
        c1.ExibirDados();
    }
}