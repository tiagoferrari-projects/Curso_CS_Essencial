Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();
minhaClasse.ExibirDataAtual();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem vindo!!");
        Console.WriteLine("06/04/2024");
        //metodo chamando outro metodo
        //ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
    }

    // outra forma de sintaxe, mais reduzida
    //public void ExibirDataAtual() =>
    //  Console.WriteLine(DateTime.Now.ToShortTimeString());

}