Console.WriteLine("Informe o valor total da compra: ");
int valorTotal = int.Parse(Console.ReadLine()!);

int desconto = 0;

if (valorTotal >= 200) {
    desconto = (int)(valorTotal * 0.10);
}else {
    desconto = 0;
}

double valorFinal = valorTotal - desconto;

Console.WriteLine($"Valor original: R$ {valorTotal}");
Console.WriteLine($"Desconto aplicado: R$ {desconto}");
Console.WriteLine($"Valor final: R$ {valorFinal}");