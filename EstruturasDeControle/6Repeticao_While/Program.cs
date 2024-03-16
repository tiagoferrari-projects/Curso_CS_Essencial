Console.WriteLine(" ## Instrução While ##\n");

//var i = 1;
//while (i <= 10)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}

//var i = 10;
//while (i > 0)
//{
//    Console.WriteLine($"i = {i}");
//    i--;
//}

// tabuada de uma numero maior que zero
//int numero;
//int contador = 1;
//int resultado;

//Console.WriteLine("\nDigite um número maior que zero\t");
//numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{
//    //loop while
//    Console.WriteLine($"\n## Tabuada do {numero} ##\n");
//    while (contador < 11)
//    {
//        resultado = numero * contador;
//        Console.WriteLine($"{numero} x { contador} = {resultado}");
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("\nNúmero deve ser maior que zero!!");
//}

//utilizando break

//while (true)
//{
//    Console.WriteLine("\nInforme um número inteiro: (Para sair tecle 999)");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999)
//        break;

//    if (numero % 2 == 0)
//        Console.WriteLine($"{numero} é PAR");
//    else
//        Console.WriteLine($"{numero} é IMPAR");

//}

// while aninhado
int x = 0;

while (x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x}, {y})");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();