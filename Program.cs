Console.WriteLine("Informe a quantidade inicial em estoque: ");
int estoque = int.Parse(Console.ReadLine()!);

Console.WriteLine("Escolha a operação: ");
int operacao = int.Parse(Console.ReadLine()!);

while (operacao != 4) {
    if (operacao == 1) {
        Console.WriteLine("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        estoque += quantidade;
        Console.WriteLine($"Entrada registrada. Estoque atual: {estoque}");
    } else if (operacao == 2) {
        Console.WriteLine("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        if (quantidade > estoque) {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        } else {
            estoque -= quantidade;
            Console.WriteLine($"Saída registrada. Estoque atual: {estoque}");
        }
    } else if (operacao == 3) {
        Console.WriteLine($"Estoque atual: {estoque}");
    }

    Console.WriteLine("Escolha a operação: ");
    operacao = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Estoque final: {estoque}");