// See https://aka.ms/new-console-template for more information

string nome, sobrenome;
Console.Write("Digite seu nome ");
nome = Console.ReadLine()!;
Console.Write("Digite seu último sobrenome ");
sobrenome = Console.ReadLine()!;

Console.WriteLine("Aperte a proxima tecla para continuar");
Console.ReadLine();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome},{nome}");
