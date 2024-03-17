Console.WriteLine(" -- EXERCÍCIO 03 --\n");

Console.WriteLine("3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop\r\nwhile, do-while e for.");

//Modelo de Saída:
//Os 10 primeiros números naturais são :
//1 2 3 4 5 6 7 8 9 10
//A soma dos números é : 55


Console.WriteLine("Utilizando WHILE");

int contador = 1;
int somaDosNumeros = 0;

Console.WriteLine("Os 10 primeiros números naturais são: ");

while (contador <= 10)
{
    somaDosNumeros = somaDosNumeros + contador;    
    Console.Write($"{contador} ");
    contador++;
}

Console.WriteLine($"\n\nA soma dos números é: {somaDosNumeros}");


Console.Write("\nDigite ENTER para sair");
Console.ReadKey();