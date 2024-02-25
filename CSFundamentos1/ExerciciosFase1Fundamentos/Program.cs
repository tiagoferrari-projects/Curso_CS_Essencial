using System.Net;

Console.WriteLine("## EXERCÍCIOS FASE 1 ## ");
Console.WriteLine();

Console.WriteLine("1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.");
int idade = 35;
Console.WriteLine($"R: {idade}\n");

Console.WriteLine("2 - Crie uma variável chamada nome e atribua o valor \"Maria\" e exiba o seu valor.");
string nome = "Maria";
Console.WriteLine($"R: {nome}\n");

Console.WriteLine("3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.");
double altura = 3.45;
Console.WriteLine($"R: {altura}\n");

Console.WriteLine("4 - Crie uma variável chamada data e atribua a ela a data 04 / 09 / 1999 e exiba o seu valor.");
DateTime data = new DateTime(1999,09,04);
Console.WriteLine($"R: {data}\n");

Console.WriteLine("5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor.");
const int ANO = 12;
Console.WriteLine($"R: {ANO}\n");

Console.WriteLine("6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.");
double? nota = 7.80;
Console.WriteLine($"R: {nota}\n");

Console.WriteLine("7 - Quais as diferenças entre os tipos por valor e os tipos por referência?");
Console.WriteLine("Tipo de Valor: Uma variável de um tipo de valor contém uma instância do tipo, contêm diretamente seus dados, armazenada na memória Stack.\r\n" +
                  "Tipos de Referência: Uma variável de um tipo de referência contém uma referência a uma instância do tipo, armazenam referências a seus dados e não seus dados diretamente, armazena na memória Heap.\n");


Console.WriteLine("8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:\r\n" +
    "(int) x = 10;\r\n" +
    "(double) numero = 7.99;\r\n" +
    "(char) letra = 'C';\r\n" +
    "(float) temperatura = 27.4f;\r\n" +
    "(bool) ativo = false;\r\n" +
    "(string) nome = \"Manoel\";\r\n" +
    "(decimal) salario = 950.99m;\r\n" +
    "(DateTime) hoje = DateTime.Now;\n");

Console.WriteLine("9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por\r\nreferência (R) :\r\n" +
    "(V) int n = 1;\r\n" +
    "(R) string titulo = \"A vida\";\r\n" +
    "(V) float f = 12.45f;\r\n" +
    "(V) double d = 5.45;\r\n" +
    "(V) decimal valor = 10.99m;\r\n" +
    "(V) char sexo = ‘M’;\r\n" +
    "(R) object o = null;\n");

Console.WriteLine("10- O que é um nullable type e qual a sua utilidade?");
Console.WriteLine("R: É um recurso do C# que nos permite atribuir o valor null a um tipo de dado que, por padrão, não aceita valores nulos, como os tipos primitivos, por exemplo.\n");

Console.WriteLine("11- O que é Camel Case? Dê um exemplo de sua aplicação.");
Console.WriteLine("R: Padrão Camel Case é utilizado na declaração de variável como uma boa prática, onde a primeira palavra se inica com a " +
    "letra mínuscula e se, caso houver as demais palavras sempre iniciam com a primeira letra maíuscula. \n" +
    "Exemplo: int aliquotaDoImposto = 18\n");

Console.WriteLine("12- O que é Pascal Case ? Dê um exemplo de sua aplicação.");
Console.WriteLine("R: Semelhante ao Camel Case, a diferença é que toda palavra na declaração de uma variável se inica com a primeira letra maíscula.\n" +
    "Exemplo: public double CalcularImposto()\n");

Console.WriteLine("13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a\r\nseguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a\r\noperação de soma)");
int x = 77;
int y = 66;
Console.WriteLine($"R: {x + y}\n");

Console.WriteLine("14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e\r\nstring.");
Console.WriteLine("bool: O valor padrão para bool é false.\r\n" +
                  "char: O valor padrão para char é \\0 (caractere nulo) ou (U+000)\r\r\n" +
                  "int: O valor padrão para int é 0.\r\n" +
                  "double: O valor padrão para double é 0.0.\r\n" +
                  "float: O valor padrão para float é 0.0f.\r\n" +
                  "decimal: O valor padrão para decimal é 0.0m.\r\n" +
                  "string: O valor padrão para string é null.\n");

Console.WriteLine("15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis\r\nconsiderando a nomenclatura usada:\r\n" +
    "(F) double 1valor = 12.45;\r\n" +
    "(F) string #nome = \"Pedro\";\r\n" +
    "(V) float _temperatura = 12.45f;\r\n" +
    "(F) double int = 5;\r\n" +
    "(F) decimal renda extra = 91.45m;\r\n" +
    "(F) bool status$conta = false;\r\n" +
    "(V) string titulo3 = “Tópico 1”;\r\n" +
    "(V) float salario_mensal = 1999.55f;\r\n" +
    "(V) int percentualValorDesconto = 5;\r\n" +
    "(V) const bool MENSALIDADE_EM_DIA = true;");

Console.ReadLine();
