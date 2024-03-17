Console.WriteLine(" -- EXERCÍCIO 03 --\n");

Console.WriteLine("3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop\r\nwhile, do-while e for.");

//Modelo de Saída:
//Os 10 primeiros números naturais são :
//1 2 3 4 5 6 7 8 9 10
//A soma dos números é : 55


Console.WriteLine(" --- Utilizando WHILE --- ");

int contadorWhile = 1;
int somaComWhile = 0;

Console.WriteLine("Os 10 primeiros números naturais são: ");

while (contadorWhile <= 10)
{
    somaComWhile = somaComWhile + contadorWhile;
    Console.Write($"{contadorWhile} ");
    contadorWhile++;
}

Console.WriteLine($"\n\nA soma dos números é: {somaComWhile}");


Console.WriteLine("\n--- Utilizando DO-WHILE ---");
int contadorDoWhile = 1;
int somaComDoWhile = 0;

do
{
    somaComDoWhile += contadorDoWhile;
    Console.Write($"{contadorDoWhile} ");
    contadorDoWhile++;
}
while (contadorDoWhile <= 10);

Console.WriteLine($"\n\nA soma dos números é: {somaComDoWhile}");


Console.WriteLine("\n--- Utilizando FOR ---");

Console.WriteLine("Os 10 primeiros números naturais são: ");

int somaComFor = 0;

for (int contadorComFor = 1; contadorComFor <= 10; contadorComFor++)
{
    Console.Write($"{contadorComFor} ");
    somaComFor += contadorComFor;
}
Console.WriteLine($"\n\nA soma dos números é: {somaComFor}");

Console.Write("\nDigite ENTER para sair");
Console.ReadKey();