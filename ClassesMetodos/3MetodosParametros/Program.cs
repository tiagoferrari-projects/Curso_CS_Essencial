Console.WriteLine("## Métodos com Parâmetros ##\n");

MinhaClasse minhaClasse = new MinhaClasse();

// valores dos argumentos
minhaClasse.Saudacao("Maria",DateTime.Now.ToShortDateString());

Console.ReadKey();


public class MinhaClasse
{
    // os parametros do metodo
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}
