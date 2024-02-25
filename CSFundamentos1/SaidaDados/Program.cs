Console.WriteLine("Saída de Dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

// escreve na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine("\n---------concatenação-----------");

// usar a concatenação: usando o operador + 
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.Write(nome + " tem " + idade + " anos.");
Console.WriteLine("\n---------interpolação-----------");


// usar interpolação de strings: $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos.");

// usar place holders(depreciado): usa {} com numeração com início zero.
Console.WriteLine("---------place holders-----------");
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadLine();
