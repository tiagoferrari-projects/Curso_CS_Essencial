Console.WriteLine("## Herança- Sealed ##\n");

#region "Situacao 1"
//Cliente cliente = new Cliente();
//cliente.Nome = "Ferrari";
//cliente.ExibeNome();

//Console.ReadKey();

//sealed class Pessoa
//{
//    public string? Nome { get; set; }
//    public void ExibeNome()
//    {
//        Console.WriteLine($"\nMeu nome é {Nome}");
//    }
//}

//class Cliente : Pessoa
//{
//    public new void ExibeNome()
//    {
//        Console.WriteLine($"\nNome do cliente : {Nome}");
//    }
//}
#endregion

#region "Situacao 2"

Console.ReadKey();


class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

class Classe2 : Classe1
{
    //tentar sobrescrever Metodo1() causa um erro CS0239
    //protected override void Metodo1()
    //{
    //    Console.WriteLine("ClasseBase.Metodo1()");
    //}
    protected override void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }
}

#endregion