Console.WriteLine("Idade do Visitante: ");
int Idade = int.Parse(Console.ReadLine()!);

if (Idade >= 16) {
    Console.WriteLine("Entrada liberada.");
} else{
    Console.WriteLine("Entrada permitida somente com responsável.");
}