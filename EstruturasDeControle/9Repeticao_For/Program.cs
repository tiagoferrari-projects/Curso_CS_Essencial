Console.WriteLine("## Instrução for ##\n");

// loop for parte 2
//for (int i = 0, j = 0; i + j <= 20;i++, j++)
//{
//    Console.WriteLine($"i = {i} e j = {j}");
//}

// declarando i fora do loop e iterando dentro do loop 
//int i = 1;
//for (; i<= 20;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

// declarando sem i, sem condição e sem iteração
// neste exemplo um loop infinito
//int i = 1;
//for (; ;)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

// loop aninhado
for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y})");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do Processamento...");
Console.ReadKey();
