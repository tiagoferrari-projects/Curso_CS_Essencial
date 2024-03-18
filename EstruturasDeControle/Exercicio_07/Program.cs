Console.WriteLine("-- EXERCICIO 07 --\n");

Console.WriteLine("7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*)." +
    "\r\nEx:" +
    "\r\n*" +
    "\r\n**" +
    "\r\n***" +
    "\r\n****" +
    "\r\n(dica : loop aninhado)");

Console.Write("\nDeseja imprimir quantas linhas: \t\n");
int quantidadeLinhas = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= quantidadeLinhas; i++)
{
    for (int y = 1; y <= i; y++)
        Console.Write("*");
    Console.WriteLine();
}


Console.WriteLine("\n\nFim do processamento...");
Console.ReadKey();