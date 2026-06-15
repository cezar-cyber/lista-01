Console.WriteLine("Informe a idade do passageiro: ");
int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe o valor normal da passagem: ");
int valorNormal = int.Parse(Console.ReadLine()!);

int valorPagar = 0;

if (idade <= 5) {
    valorPagar = 0;
} else if (idade >= 60) {
    valorPagar = (int)(valorNormal * 0.5);
} else {
    valorPagar = valorNormal;
}

Console.WriteLine($"Valor normal da passagem: R$ {valorNormal}");
Console.WriteLine($"Valor a pagar: R$ {valorPagar}");