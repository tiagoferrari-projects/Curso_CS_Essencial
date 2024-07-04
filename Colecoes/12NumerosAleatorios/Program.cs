Console.WriteLine("## Classe Random ##\n");

//Random random = new Random();

//Console.WriteLine(random.Next());
//Console.WriteLine(random.Next(20));
//Console.WriteLine(random.Next(10, 20));
//Console.WriteLine(random.NextDouble());

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(random.NextDouble());
//}

//byte[] randBytes = new byte[10];
//Random random = new Random(2024);
//random.NextBytes(randBytes);

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(randBytes[i]);
//}

Console.WriteLine("Sorteio da Mega Sena\n");

Random random = new Random();

int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    } while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);
Console.WriteLine("Numeros Sorteados: ");
Console.WriteLine($"{string.Join(" ",numerosSorteados)}");

Console.ReadKey();
