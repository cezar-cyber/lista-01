Console.WriteLine("Informe o saldo inicial: ");
int saldo = int.Parse(Console.ReadLine()!);

Console.WriteLine("Escolha a operação: ");
int operacao = int.Parse(Console.ReadLine()!);

while (operacao != 3) {
    if (operacao == 1) {
        Console.WriteLine("Informe o valor da movimentação: ");
        int valor = int.Parse(Console.ReadLine()!);
        saldo += valor;
        Console.WriteLine($"Entrada registrada. Saldo atual: R$ {saldo}");
    } else if (operacao == 2) {
        Console.WriteLine("Informe o valor da movimentação: ");
        int valor = int.Parse(Console.ReadLine()!);
        if (valor > saldo) {
            Console.WriteLine("Saldo insuficiente.");
        } else {
            saldo -= valor;
            Console.WriteLine($"Saída registrada. Saldo atual: R$ {saldo}");
        }
    }

    Console.WriteLine("Escolha a operação: ");
    operacao = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Saldo final: R$ {saldo}");