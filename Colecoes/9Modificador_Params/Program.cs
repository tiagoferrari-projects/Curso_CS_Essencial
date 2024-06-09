Console.WriteLine("Soma de Números Inteiros\n");

int[] valores = { 1, 2, 3, 4, 5 };

int resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

int resultado2 = Calcular.Soma(10, 20, 30 );
Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}