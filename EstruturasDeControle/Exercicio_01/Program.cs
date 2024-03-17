Console.WriteLine(" -- EXERCÍCIO 01 --");

Console.WriteLine("\n1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior: ");
//Modelo de saída:
//Encontre o maior dentre 3 números:
//    Primeiro Número : 65465
//    Segundo Número : 64658
//    Terceiro Número : 65464
//    O primeiro número : 65465 é o maior

Console.Write("\nInforme o Primeiro Número: \t");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o Segundo Número: \t");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o Terceiro Número: \t");
int terceiroNumero = Convert.ToInt32(Console.ReadLine());

if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
    Console.Write($"\nO Primeiro Número: {primeiroNumero} é o maior");
else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
    Console.Write($"\nO Segundo Número: {segundoNumero} é o maior");
else if (terceiroNumero > primeiroNumero && terceiroNumero > segundoNumero)
    Console.Write($"\nO Terceiro Número: {terceiroNumero} é o maior");
else
    Console.Write("\nOs três números são iguais!!");


Console.Write("\nDigite ENTER para sair");
Console.ReadKey();