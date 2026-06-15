Console.WriteLine("Informe a primeira pontuação: ");
int p1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe a segunda pontuação: ");
int p2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe a terceira pontuação: ");
int p3 = int.Parse(Console.ReadLine()!);

if (p1 == p2 && p2 == p3) {
    Console.WriteLine("As três pontuações são iguais.");
} else if (p1 >= p2 && p1 >= p3) {
    Console.WriteLine($"Maior pontuação: {p1}");
} else if (p2 >= p1 && p2 >= p3) {
    Console.WriteLine($"Maior pontuação: {p2}");
} else {
    Console.WriteLine($"Maior pontuação: {p3}");
}