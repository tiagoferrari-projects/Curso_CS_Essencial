Console.WriteLine("## Instrução for ##\n");

//int resultado, numero;

//Console.Write("Informe o número inteiro: \n");
//numero = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    resultado = numero * i;
//    Console.WriteLine($"{numero} x {i} = {resultado}");
//}

double resultado, numero, i;

Console.Write("Informe o número inteiro: \n");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (i = 10; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}


Console.WriteLine("\nFim do Processamento...");
Console.ReadKey();
