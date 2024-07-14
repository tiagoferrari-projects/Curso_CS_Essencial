Console.WriteLine("## Herança - Construtores ##\n");

Aluno aluno = new Aluno();

Console.ReadKey();


// base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
}

// derivada
class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
}
