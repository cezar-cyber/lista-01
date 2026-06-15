Console.WriteLine("Informe o número inicial da contagem regressiva: ");
int inicial = int.Parse(Console.ReadLine()!);

for (int i = inicial; i >= 0; i--) {
    Console.WriteLine(i);
}

Console.WriteLine("Fim da contagem.");