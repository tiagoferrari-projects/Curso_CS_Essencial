﻿Console.WriteLine("## Estrutura de repetição com goto/label ##\n");

int i = 1;

repetir:
Console.WriteLine($"i = {i}");
i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();