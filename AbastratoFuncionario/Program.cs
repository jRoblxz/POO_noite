﻿// Main()

using AbastratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);
Comissionado c1 = new Comissionado(3, "Bel", 1000, 20);
Comissionado c2 = new Comissionado(4, "Lia", 1000, 30);

Departamneto d1 = new Departamneto(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();

Departamneto d2 = new Departamneto(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
//d2.Demitir(4);
//d2.ListarFuncionarios();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");