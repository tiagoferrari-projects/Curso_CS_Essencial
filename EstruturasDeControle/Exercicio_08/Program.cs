Console.WriteLine("-- EXERCICIO 08 --\n");

Console.WriteLine("8- Escreva um programa para calcular o fatorial de um número inteiro." +
    "\r\nO fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1" +
    "\r\nExemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1");

Console.Write("\nDigite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

int fator = 1;
for(int i = 1; i <= numero; i++)
{
    fator *= i;
}
Console.WriteLine($"\nFatorial de {numero}! = {fator}");

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();