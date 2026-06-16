Console.WriteLine("Informe o primeiro valor: ");
int v1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe o segundo valor: ");
int v2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe o terceiro valor: ");
int v3 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe o quarto valor: ");
int v4 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe o quinto valor: ");
int v5 = int.Parse(Console.ReadLine()!);

int soma = v1 + v2 + v3 + v4 + v5;
double media = soma / 5.0;

Console.WriteLine($"Soma dos valores: {soma}");
Console.WriteLine($"Média dos valores: {media}");