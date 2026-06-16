Console.WriteLine("Informe a quantidade de clientes atendidos: ");
int clientes = int.Parse(Console.ReadLine()!);

int totalTempo = 0;

for (int i = 0; i < clientes; i++) {
    Console.WriteLine("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine()!);
    totalTempo += tempo;
}

int mediaTempo = (int)(totalTempo / clientes);

Console.WriteLine($"Tempo total de atendimento: {totalTempo} minutos");
Console.WriteLine($"Tempo médio por cliente: {mediaTempo} minutos");