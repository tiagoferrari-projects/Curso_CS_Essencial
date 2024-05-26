Console.WriteLine("## Tipo Anonimos ##\n");

#region "Exemplo 1"
//var aluno = new
//{
//    Nome = "Maria",
//    Idade = 43
//};

// as propriedades são somente leitura
// aluno.Idade = 35;

#endregion

#region "Exemplo 2"
//var aluno = new
//{
//    Id = 1,
//    Nome = "Jairo",
//    Email = "jairo@email.com",
//    Endereco = new {Id = 1, Cidade = "Araraquara", Pais = "Brasil"}
//};
//Console.WriteLine(aluno.Nome);
//Console.WriteLine(aluno.Endereco.Cidade);
#endregion

#region "Exemplo 3"
var alunos = new[]
{
    new {Id = 1, Nome = "Maria", Email = "maria@email.com"},
    new {Id = 2, Nome = "Sonia", Email = "sonia@email.com"},
    new {Id = 3, Nome = "Bruno", Email = "bruno@email.com"}
};
Console.WriteLine(alunos[0].Nome);
Console.WriteLine(alunos[0].Email);
#endregion

Console.ReadKey();