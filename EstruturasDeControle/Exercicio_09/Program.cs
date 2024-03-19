Console.WriteLine("-- EXERCICIO 09 --\n");

Console.WriteLine("9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado\n");

int numero = 2;
do
{
    for (int i = 0; i <= 10; i++)
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
    Console.WriteLine();
    numero++;
} while (numero <= 6);


Console.WriteLine("\nFim do processamento...");
Console.ReadKey();