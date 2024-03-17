Console.WriteLine("## break e continue ##\n");

// break com loop for
//for (; ; )
//{
//    Console.WriteLine("Tecle algo (X sai)");
//    var opcao = Console.ReadLine();

//    Console.WriteLine(opcao.ToUpper());

//    if (opcao == "X" || opcao == "x")
//    {
//        Console.WriteLine("Tchau...");
//        break;
//    }
//}

// continue com loop for
//for (int i = 1; i <= 10; i++)
//{
//    if (i == 4)
//        continue;
//    Console.WriteLine(i);
//}

// continue com loop while
//int n = 1;
//while(n <= 10)
//{
//    if(n == 5)
//    {
//        n++;
//        continue;
//    }
//    Console.WriteLine($"n = {n}");
//    n++;
//}

// break e continue no mesmo loop
for (int i = 1; i < 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine($"i = {i}");
}

Console.WriteLine("\nFim do Processamento...");
Console.ReadKey();
