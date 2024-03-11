Console.WriteLine("## Estrutura switch-case ##\n");
/*
// numero de parcelas
int compra = 600;
Console.WriteLine($"Valor da compra R${compra}");

Console.WriteLine("Informe o número de parcelas (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Valor inválido, informe 1, 2 ou 3");
        break;
}
*/

// avaliando o valor de uma expressão: par ou impar

Console.WriteLine("Informe um número inteiro:\t");
var numero = Convert.ToInt32(Console.ReadLine());

switch(numero % 2)
{
    case 0:
        Console.WriteLine($"\n{numero} é PAR");
        break;
    case 1:
        Console.WriteLine($"\n{numero} é IMPAR");
        break;
}

Console.WriteLine("\nFim do Processamento...");
Console.ReadKey();
