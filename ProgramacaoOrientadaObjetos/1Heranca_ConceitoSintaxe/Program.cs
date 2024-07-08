Console.WriteLine("## Herança ## \n");

Funcionario funcionario = new Funcionario();

funcionario.Nome = "José";
funcionario.Email = "jose@email.com";
funcionario.Empresa = "Google Inc.";
funcionario.Salario = 9000;

Console.WriteLine("\nFuncionario");
funcionario.Identificar();
Console.WriteLine(funcionario.Empresa);
Console.WriteLine(funcionario.Salario);


Aluno aluno = new Aluno();

aluno.Nome = "João";
aluno.Email = "joao@email.com";
aluno.Curso = "ADS";
aluno.Nota = 9;

Console.WriteLine("\nAluno");
aluno.Identificar();
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);

Console.ReadKey();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }

}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}