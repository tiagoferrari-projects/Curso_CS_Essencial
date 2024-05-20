Console.WriteLine("## Métodos com Retorno ##\n");

Calculadora calc = new Calculadora();

Console.WriteLine($"Soma: {calc.Somar(10, 10)}");
Console.WriteLine($"Subtração: {calc.Subtrair(10, 10)}");
Console.WriteLine($"Multiplicação: {calc.Multiplicar(10, 10)}");
Console.WriteLine($"Divisão: {calc.Dividir(10, 10)}");

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
