Console.WriteLine("## Instrução if-else-if ##\n");

Console.WriteLine("\nInforme a nota do aluno(a)\t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("\nAluno Reprovado");
}
else if (nota >= 5 && nota < 6) 
{
    Console.WriteLine("\nAluno em Recuperação");
}
else if (nota >=6 && nota <= 9)
{
    Console.WriteLine("\nAluno Aprovado");
}
else if (nota > 9)
{
    Console.WriteLine("\nAluno Aprovado com Distinção");
}

Console.WriteLine("\nFim do Processamento...");

Console.ReadKey();
