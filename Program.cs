Console.WriteLine("Informe uma nota de 0 a 10: ");
int nota = int.Parse(Console.ReadLine()!);

while (nota < 0 || nota > 10) {
    Console.WriteLine("Nota inválida. Informe novamente.");
    Console.WriteLine("Informe uma nota de 0 a 10: ");
    nota = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Nota registrada: {nota}");