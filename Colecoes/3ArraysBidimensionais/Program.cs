Console.WriteLine("## Arrays Bidimensionais\n");

#region "Array Multidimensionais I"
//Console.WriteLine("\nArray a");
//int[,] a;

//a = new int[2, 2];

//a[0, 0] = 0;
//a[0, 1] = 1;
//a[1, 0] = 2;
//a[1, 1] = 3;

//Console.WriteLine(a[0, 0]);
//Console.WriteLine(a[0, 1]);
//Console.WriteLine(a[1, 0]);
//Console.WriteLine(a[1, 1]);

//Console.WriteLine("\nArray b");
//int[,] b = new int[2, 2] { { 10, 20 }, { 30, 40 } };
//Console.WriteLine(b[0, 0]);
//Console.WriteLine(b[0, 1]);
//Console.WriteLine(b[1, 0]);
//Console.WriteLine(b[1, 1]);

#endregion

#region "Array Multidimensionais II"

int[,] n = { 
             { 11, 22, 33 }, // n[0,0] n[0,1] n[0,2] 
             { 44, 55, 66 }, // n[1,0] n[1,1] n[1,2]   n[3, 3] -> n[i, j]
             { 77, 88, 99 }  // n[2,0] n[2,1] n[2,2] 
            };

Console.WriteLine("\n-- FOR -- \n");

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n-- FOREACH -- \n");
foreach (var x in n)
{
    Console.Write($"{x} ");
}

#endregion

Console.ReadKey();
