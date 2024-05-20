Console.WriteLine("## Passando Argumentos por valor ##\n");

int x = 20;

Console.WriteLine($"\nValor do argumento x antes de passar por valor: {x}");

Calculo calculo = new Calculo();
calculo.Dobrar( x );
Console.WriteLine($"\nValor do argumento x depois de passar por valor: {x}");

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parâmetro y no método Dobrar: {y}");
    }
}