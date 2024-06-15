Console.WriteLine("## Array Bidimensional - Exercicio ##");

string[,] alunos = new string [2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteúdo do Array Alunos");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i,j]}\t");
    }
    Console.WriteLine();
}


Console.ReadKey();
