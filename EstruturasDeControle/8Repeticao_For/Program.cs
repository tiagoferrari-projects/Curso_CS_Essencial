Console.WriteLine("## Instrução for ##\n");

//int resultado, numero;

//Console.Write("Informe o número inteiro: \n");
//numero = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    resultado = numero * i;
//    Console.WriteLine($"{numero} x {i} = {resultado}");
//}

//double resultado, numero, i;

//Console.Write("Informe o número inteiro: \n");
//numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{
//    for (i = 10; i <= 10; i++)
//    {
//        resultado = numero * i;
//        Console.WriteLine($"{numero} x {i} = {resultado}");
//    }
//}
//else
//{
//    Console.WriteLine("Número inválido");
//}

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
for(int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y})");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do Processamento...");
Console.ReadKey();
