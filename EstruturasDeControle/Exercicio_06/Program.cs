Console.WriteLine("-- EXERCICIO 06 --\n");

Console.WriteLine("6- Crie um programa para exibir no console os números pares de 10 a 20, ambos incluídos, exceto o 16, de 3\r\nmaneiras diferentes:" +
    "\r\n- Incrementando 2 em cada passo" +
    "\r\n- Incrementando 1 em cada passo" +
    "\r\n- Com e loop infinito (use \"break\" e \"continue\")\n");

Console.WriteLine("--- Incrementando 2 em cada passo ---");
for (int numero = 10; numero <= 20; numero+=2)
{
    if(numero == 16)
        continue;
    Console.Write($"Numero = {numero} ");
}

Console.WriteLine("\n\n--- Incrementando 1 em cada passo ---");
for (int numero = 10; numero <= 20; numero++)
{
    if (numero % 2 == 1)
        continue;
    if (numero == 16)
        continue;
    Console.Write($"Numero = {numero} ");
}

Console.WriteLine("\n\n--- Com loop infinito ---");
for (int numero = 10; ; numero += 2)
{
    if (numero == 16)
        continue;
    if (numero > 20)
        break;
    Console.Write($"Numero = {numero} ");
}


Console.WriteLine("\n\nFim do processamento...");
Console.ReadKey();