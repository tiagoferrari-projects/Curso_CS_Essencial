Console.WriteLine("//* Comparativo de List e IEnumerable*//");

var limiteCredito = new List<Limite>();

for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = i });
}

var limitesComRestricao = limiteCredito.Where(x => x.AnaliseLimite());
//var limitesComRestricao = limiteCredito.Where(x => x.AnaliseLimite()).ToList();

//if(limitesComRestricao.Count() > 3)
//{
//    Console.WriteLine("\n### Temos mais de 3 lmites com restrição");
//}

//if (limitesComRestricao.Count() > 5)
//{
//    Console.WriteLine("\n### Temos mais de 3 lmites com restrição");
//}

var primeiroLimiteComRestricao = limitesComRestricao.FirstOrDefault();
Console.WriteLine($"\n## {primeiroLimiteComRestricao?.Numero}");

// IEnumerable: uma única consulta nos dados e não precisa acessar o resultado várias vezes.Mais eficiente em termos de memória, por IEnumerable tem a execução adiada, ou seja, os elementos somente são avaliados quando são iterados.
//ToList(): Para acessar o resultado de uma consulta LINQ várias vezes ou se precisar executar operãções que modifiquem os dados, então é melhor usar  o List. Avalia imediatamente, todos os dados são recuperados e usados na memória quando a lista é criada. Torna mais eficiente na necessidade de fazer vários acessos e modificações repetidas.



Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnaliseLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero}");
        return isRestricao;
    }
}