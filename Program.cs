Console.WriteLine("Informe a nota final: ");
int nota = int.Parse(Console.ReadLine()!);

if (nota >= 7) {
    Console.WriteLine("Estudante Aprovado");
} else if (nota >= 5 && nota < 7) {
    Console.WriteLine("Estudante em Recuperação");
} else if (nota < 5) {
    Console.WriteLine("Estudante Reprovado");
}