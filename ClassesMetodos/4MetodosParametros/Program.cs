Console.WriteLine("## Métodos - Parâmetros ##\n");

Aluno aluno = new Aluno();
aluno.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }
}

public class Curso
{
    public void Resultado(Aluno aluno)
    {
        // Objeto como parametro
        Console.Write($"\nO(A) aluno(a) {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos,");
        if (aluno.Aprovado == "S")
            Console.Write(" foi Aprovado.");
        else
            Console.Write(" foi Reprovado.");
    }
    //public void Resultado(string nome, int idade, string sexo, string aprovado)
    //{
    //    Console.Write($"\nO(A) aluno(a) {nome}, sexo {sexo} com {idade} anos, ");
    //    if (aprovado == "S")
    //        Console.Write(" foi Aprovado.");
    //    else
    //        Console.Write(" foi Reprovado.");
    //}
}