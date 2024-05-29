Console.WriteLine("## Exercício Array\n");

//criar arrays
string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("--- Alunos ---");

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

Console.WriteLine("--- Notas ---");

for (int i = 0;i < notas.Length; i++)
{
    Console.Write("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.Write("\nAlunos: ");

foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

Console.Write("\nNotas: ");

double somaNotas = 0.0;
double totalNotas = notas.Count();
foreach (double nota in notas)
{
    somaNotas += nota;
    Console.Write($"{nota} ");
}

Console.WriteLine($"\nMédia Aritmética: {somaNotas / totalNotas}");

Console.ReadKey();
