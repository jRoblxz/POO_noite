using ComposicaoNotaFiscal;
internal class Program
{
    private static void Main(string[] args)
    {
        NotaFiscal nf = new NotaFiscal(1,"01/04/2025");

        ItemNotaFiscal item1 = new ItemNotaFiscal(10);
        ItemNotaFiscal item2 = new ItemNotaFiscal(21);

        nf.AdicionarItens(item1);
        nf.Mostrar();
        nf.AdicionarItens(item2);
        nf.Mostrar();
        nf = null; //retirar a referencia de memória
        GC.Collect(); //forçar a chamada do destrutor

    }
}