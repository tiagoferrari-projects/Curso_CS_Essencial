Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
string titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

// strings são imutáveis 
string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";

// StringBuilder: será tratado mais adiante, porém é utilizado em ocasiões que uma string se altera com frequência

object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = 'B';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

// dynamic semelhate ao object.
// utilizado em recursos avançados como Reflection: usado para retornar metadados de tipos em tempo de execução.
Console.WriteLine("Com dynamic...");
dynamic nota2 = 10;
dynamic valor2 = 8.55m;
dynamic nome2 = "Maria";
dynamic ativa2 = true;
dynamic letra2 = 'B';

Console.WriteLine(nota2);
Console.WriteLine(valor2);
Console.WriteLine(nome2);
Console.WriteLine(ativa2);
Console.WriteLine(letra2);


Console.ReadLine();