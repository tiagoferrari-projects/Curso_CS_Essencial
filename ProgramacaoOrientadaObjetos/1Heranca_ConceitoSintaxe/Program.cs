#region "Conceito e Sintaxe"
//Console.WriteLine("## Herança ## \n");


//Funcionario funcionario = new Funcionario();

//funcionario.Nome = "José";
//funcionario.Email = "jose@email.com";
//funcionario.Empresa = "Google Inc.";
//funcionario.Salario = 9000;

//Console.WriteLine("\nFuncionario");
//funcionario.Identificar();
//Console.WriteLine(funcionario.Empresa);
//Console.WriteLine(funcionario.Salario);


//Aluno aluno = new Aluno();

//aluno.Nome = "João";
//aluno.Email = "joao@email.com";
//aluno.Curso = "ADS";
//aluno.Nota = 9;

//Console.WriteLine("\nAluno");
//aluno.Identificar();
//Console.WriteLine(aluno.Curso);
//Console.WriteLine(aluno.Nota);


//Console.ReadKey();


//public class Pessoa
//{
//    public string? Nome { get; set; }
//    public string? Email { get; set; }
//    public void Identificar()
//    {
//        Console.WriteLine($"{Nome} - {Email}");
//    }

//}

//public class Funcionario : Pessoa
//{
//    public string? Empresa { get; set; }
//    public decimal Salario { get; set; }
//}

//public class Aluno : Pessoa
//{
//    public string? Curso { get; set; }
//    public int Nota { get; set; }
//}
#endregion

#region "Comportamentos"

ClasseDerivada classeDerivada = new ClasseDerivada();
classeDerivada.VerificarAcesso();

Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificarAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();
        //Private_Membro();

        Console.WriteLine("\nAcesso ao campo private : private_var usando uma propriedade GET");
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine($"\nTotal Soma: {soma}");
    }
}

public class ClasseBase
{
    // campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;  

    // propriedade
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protectec Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }

}

#endregion