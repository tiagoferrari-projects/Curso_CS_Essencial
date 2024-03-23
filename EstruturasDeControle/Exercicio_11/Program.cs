Console.WriteLine("-- EXERCICIO 11 --\n");

Console.WriteLine("11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números" +
    "\r\ninteiros. (Considere que na divisão podemos ter números fracionários e que não existe divisão por zero e" +
    "\r\nquando isso ocorrer exibir uma mensagem de alerta).");

// Modelos de saída esperados:                  Informe o primeiro número: 1
// Informe o primeiro número: 78                Informe o operando (+, -, /, *): /
// Informe o operando (+, -, /, *): +           Informe o segundo número: 0
// Informe o segundo número: 22                 Não existe divisão por zero !!!
// 78 + 22 = 100                                1 / 0 = 8 (Símbolo de infinito)

Console.Write("Informe um número inteiro: \t");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe qual operação deseja realizar (+, -, /, *): \t");
char opcao = Convert.ToChar(Console.ReadLine());

Console.Write("Informe outro número inteiro: \t");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

int operacao = 0;

if (opcao == '+')
{
    operacao = primeiroNumero + segundoNumero;
}
if (opcao == '-')
{
    operacao = primeiroNumero - segundoNumero;
}
if (opcao == '*')
{
    operacao = primeiroNumero * segundoNumero;
}

if (opcao == '/')
{
    if (segundoNumero != 0)
    {
        operacao = (int)((double)primeiroNumero / segundoNumero);
    }
    else
    {
        Console.WriteLine("\nNão existe divisão por zero!!!");
        operacao = 8;  
    }
}

Console.WriteLine($"\n{primeiroNumero} {opcao} {segundoNumero} = {operacao}");



Console.WriteLine("\n\nFim do processamento...");
Console.ReadKey();