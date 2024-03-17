Console.WriteLine(" -- EXERCÍCIO 04 --\n");

Console.WriteLine("4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero\r\nrecebido via teclado" +
    "\r\n- Verifique se o número é maior que zero e emita uma mensagem" +
    "\r\n- Considere a tabela de multiplicação de 1 até 10" +
    "\r\n- Após exibir a tabela torne a solicitar outro número" +
    "\r\n- Para sair do loop defina uma condição de saída" +
    "\r\nDica: Use os loop while e for e para sair a instrução break");

while (true)
{
    Console.Write("\nInforme um número inteiro maior que zero, para sair digite 999:\t");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
    {
        Console.WriteLine("\nVocê digitou 999.\nFim do Processamento!!");
        break;
    }

    if (numero <= 0)
    {
        Console.WriteLine("\nVocê digitou um número menor ou igual a zero!\nFim do Processamento!!");
        break;
    }

    if (numero > 0)
    {
        Console.WriteLine($"\nVocê escolheu a tabela de multiplicação do número: {numero}\n");
        int resultado;
        for (int i = 0; i <= 10; i++)
        {
            resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}

Console.ReadKey();