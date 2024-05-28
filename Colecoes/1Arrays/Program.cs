Console.WriteLine("## Arrays ##\n");

#region "Arrays I"
//// declaração do array
//int[] numeros;

//// aloquei memória
//numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//string[] nomes = new string[5] {"Ana", "Maria", "Marta", "Paulo", "Carlos"};
//string[] nomes1 = new string[] {"Ana", "Maria", "Marta", "Paulo", "Carlos"};
//string[] nomes2 = {"Ana", "Maria", "Marta", "Paulo", "Carlos"};

//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);
//Console.WriteLine(nomes[2]);
//Console.WriteLine(nomes[3]);
//Console.WriteLine(nomes[4]);

//// declarando um array
//int[] numeros1;

////alocar memória
//numeros1 = new int[3];

//numeros1[0] = 1;
//numeros1[1] = 2;
//numeros1[2] = 3;
//// numeros1[3] = 4; erro System.IndexOutOfRangeException
#endregion

#region "Arrays II"

//int[] numeros;
//// aloquei memoria
//numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
//}

//Console.WriteLine();

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
//}

#endregion

#region "Arrays III"

int[] numeros;
// aloquei memoria
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

foreach (int numero in numeros)
{
    Console.Write($"{numero} ");
}

Console.WriteLine();

foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

#endregion

Console.ReadKey();