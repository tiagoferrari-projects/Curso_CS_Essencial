Console.WriteLine("## Herança- Virtual e Override ##\n");

Gato gato = new Gato() { Nome = "bichano"};
gato.ExibeNome();

Cachorro cachorro = new Cachorro() { Nome = "pipoca"};
cachorro.ExibeNome();


Console.ReadKey();

// classe Base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

// classe Derivada
class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é {Nome}");
    }
}

class Cachorro : Animal
{

}