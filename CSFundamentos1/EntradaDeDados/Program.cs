Console.WriteLine("## Entrada de Dados ##\n");

Console.WriteLine("\nInforme seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO seu nome é {nome} e você tem {idade} anos.");

Console.ReadKey();