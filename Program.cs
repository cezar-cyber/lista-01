Console.WriteLine("temperatura atual em graus celsius: "); 
float temperatura = float.Parse(Console.ReadLine()!);
if (temperatura < 18) 
{ 
    Console.WriteLine("ambiente frio"); 
} 
else if (temperatura >= 18 && temperatura <= 26) 
{ 
    Console.WriteLine("ambiente confortável."); 
} 
else 
{ 
    Console.WriteLine("ambiente quente"); 
}
