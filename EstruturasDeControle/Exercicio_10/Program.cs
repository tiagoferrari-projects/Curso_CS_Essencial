using System.Xml;

Console.WriteLine("-- EXERCICIO 10 --\n");

Console.WriteLine("10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de" +
    "\r\num aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a" +
    "\r\ninstrução switch, break e default em um loop infinito e defina uma condição de saida." +
    "Nota Avaliação" +
    "\r\n10 = A+" +
    "\r\n9  = A" +
    "\r\n7 e 8 = B" +
    "\r\n6 = C" +
    "\r\n5 = E" +
    "\r\n0 a 4 = F\n");

Console.Write("Informe a nota do Aluno de 0 a 10. Para sair digite 999: \t");
int notaDoAluno = Convert.ToInt32(Console.ReadLine());

switch (notaDoAluno)
{
    case 999:
        break;
    case 10:
        Console.WriteLine("Sua avaliação foi: A+");
        break;
    case 9:
        Console.WriteLine("Sua avaliação foi: A");
        break;
    case 8:
    case 7:
        Console.WriteLine("Sua avaliação foi: B");
        break;
    case 6:
        Console.WriteLine("Sua avaliação foi: C");
        break;
    case 5:
        Console.WriteLine("Sua avaliação foi: E");
        break;
    case 4:
    case 3:
    case 2:
    case 1:
    case 0:
        Console.WriteLine("Sua avaliação foi: F");
        break;
    default:
        Console.WriteLine("Você não digitou uma nota inválida!");
        break;

}

Console.WriteLine("\n\nFim do processamento...");
Console.ReadKey();