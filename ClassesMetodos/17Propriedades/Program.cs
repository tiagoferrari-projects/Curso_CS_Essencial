Console.WriteLine("## Propriedades ##\n");

Produto p1 = new Produto();
p1.Nome = "Caderno Espiral";
p1.Preco = 10.00;
//p1.Desconto = 0.05;
//p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
p1.EstoqueMinimo = 10;
p1.Exibir();

Console.ReadKey();


public class Produto
{
    private string? nome;
    private double preco;
    private double desconto;
    private int minimo;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }
    public double Desconto
    {
        get { return desconto; }
    }
    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }
    public int EstoqueMinimo
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome}\n" +
            $"{Preco.ToString("c")}\n" +
            $"{Desconto}\n" +
            $"{PrecoFinal.ToString("c")}\n" +
            $"{minimo}");
    }
}