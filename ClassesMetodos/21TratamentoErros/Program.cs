Console.WriteLine("## Divisão de números inteiros ## \n");

Console.Write("\nInforme o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());





try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch(Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");
    Console.WriteLine($"\nErro: {ex.Message}");
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}

Console.ReadKey();
