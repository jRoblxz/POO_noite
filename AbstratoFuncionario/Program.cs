// Main()

using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Joao", 1000);
Assalariado a2 = new Assalariado(2, "Pedro", 1000);
Comissionado c1 = new Comissionado(3, "Costa", 1000, 20);
Comissionado c2 = new Comissionado(4, "Roblez", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
//d2.Demitir(4);
//d2.ListarFuncionarios();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");

Dependente dep1 = new Dependente(1, "Miguel", 10);
Dependente dep2 = new Dependente(2, "Carine", 17);
Dependente dep3 = new Dependente(3, "Manu", 20);


a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);
c1.AdicionarDependente(dep3);


a1.ListarDependentes();
c1.ListarDependentes();


c1.RemoverDependentesMaioridade(3);


c1.ListarDependentes();


d1.MostrarQtdeDependentesFuncionario();
d2.MostrarQtdeDependentesFuncionario();