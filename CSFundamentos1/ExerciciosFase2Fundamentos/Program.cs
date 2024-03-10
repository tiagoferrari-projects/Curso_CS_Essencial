Console.WriteLine("## EXERCÍCIOS FASE 2 ## \n");

Console.WriteLine("1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :\r\n" +
    "Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.\nR: ");
string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

Console.WriteLine("\n2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de\r\nescapes.\nR: ");
Console.WriteLine($"Aluno {nome} tem \n{idade} anos e \nnota {nota}");

Console.WriteLine("\n3- Para qual tipo de dados você pode converter um float implicitamente ?\r\n" +
    "() int\r\n" +
    "(X) double\r\n" +
    "() long\r\n" +
    "(X) decimal");

Console.WriteLine("\n4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?\r\n" +
    "() int para long\r\n" +
    "(X) double para long\r\n" +
    "(X) double para float\r\n" +
    "(X) decimal para float\r\n" +
    "(X) long para int\r\n" +
    "(X) double para decimal");

Console.WriteLine("\n5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando\r\na concatenação e também a interpolação de strings.\nR: ");
Console.Write("Informe a letra 1: ");
char letra1 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra 2: ");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra 3: ");
char letra3 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Letra 03: " + letra3 + " Letra 02: " + letra2 + " Letra 01: " + letra1);
Console.WriteLine($"Letra 03: {letra3} Letra 02: {letra2} Letra 01: {letra1}");

Console.WriteLine("\n6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:\r\n" +
    "(F) long resultado = 1.32;\r\n" +
    "(V) var nome = “Maria”;\r\n" +
    "(V) string resultado = 100.ToString();\r\n" +
    "(V) A sequência de escape \\n inclui uma nova linha\r\n" +
    "(F) float f = 5.45;\r\n" +
    "(V) decimal valor = (decimal) 10.99f;\r\n" +
    "(F) var status = null;\r\n" +
    "(V) object o = 12.45m;\r\n" +
    "(V) string titulo = true.ToString();\r\n" +
    "(F) A sequencia \\t inclui uma tabulação vertical");

Console.WriteLine("\n7- Escreva um programa para receber dois valores via teclado " +
    "do tipo double e a seguir\r\nrealize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo\r\n" +
    "exibindo o resultado.\nR: ");
Console.WriteLine("Digite um número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Soma: {numero1 + numero2}");
Console.WriteLine($"Subtração: {numero1 - numero2}");
Console.WriteLine($"Multiplicação: {numero1 * numero2}");
Console.WriteLine($"Exponenciação: {Math.Pow(numero1, numero2)}");
Console.WriteLine($"Divisão: {numero1 / numero2}");
Console.WriteLine($"Módulo: {numero1 % numero2}");

Console.WriteLine("\n8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de\r\na b e c .\r\n" +
    "Valores : a = 1 , b = 12 e c = -13");
int a = 1, b = 12, c = -13;
double delta , x1 , x2;
delta = Math.Pow(b, 2) - 4 * a * c;
x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine($"Resultado x1: {x1}");
Console.WriteLine($"Resultado x2: {x2}");

Console.WriteLine("\n9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e\r\n" +
    "Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’\r\n" +
    "então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem " +
    "‘Login\r\ninválido’: (use o operador condicional ternário)");
Console.WriteLine("Informe seu nome: ");
string nomeExercicioNove = Console.ReadLine();
Console.WriteLine("Qual a senha de acesso: ");
int senha = Convert.ToInt32(Console.ReadLine());
string mensagem = (nomeExercicioNove == "admin" || nomeExercicioNove == "maria") 
                    && senha == 123 ? 
                    "Login feito com sucesso" : "Login inválido";
Console.WriteLine(mensagem);

Console.WriteLine("\n10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando\r\na nomenclatura usada:\r\n" +
    "(V) string? nome; é um exemplo de nullable reference type;\r\n" +
    "(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1\r\n" +
    "(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)\r\n" +
    "(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1\r\n" +
    "(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”\r\n" +
    "(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;\r\n" +
    "(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null\r\n" +
    "(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;\r\n" +
    "(F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;\r\n" +
    "(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException\r\n" +
    "(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador \"?\"");

Console.WriteLine("\n11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no\r\n" +
    "console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)\nR: ");
Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string resultadoDeX = x % 2 == 0 ? "X é par" : "X NÃO é par";
string resultadoDeY = y % 2 == 0 ? "Y é par" : "Y NÃO é par";

Console.WriteLine(resultadoDeX);
Console.WriteLine(resultadoDeY);


Console.WriteLine("\n12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no\r\n" +
    "console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)\r\n" +
    "-6 + x * 5\r\n" +
    "(13-2) * x\r\n" +
    "(x + -2) * (20 / x)\r\n" +
    "(12 + x) / (x - 4)\r\n" +
    "3 x^2 + x + 10\r\n" +
    "pi * x^2");
const double PI = 3.1415;
Console.WriteLine("Informe o valor de x");
int valorDeXExercicio12 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Expressão: -6 + x * 5 = {-6 + valorDeXExercicio12 * 5}");
Console.WriteLine($"Expressão: (13-2) * x = {(13 - 2) * valorDeXExercicio12}");
Console.WriteLine($"Expressão: (x + -2) * (20 / x) = {(valorDeXExercicio12 + -2) * (20 / valorDeXExercicio12)}");
Console.WriteLine($"Expressão: (12 + x) / (x - 4) = {(12 + valorDeXExercicio12) / (valorDeXExercicio12 - 4)}");
Console.WriteLine($"Expressão: 3 x^2 + x + 10 = {3 * Math.Pow(valorDeXExercicio12, 2) + valorDeXExercicio12 + 10}");
Console.WriteLine($"Expressão: pi * x^2 = {(double) PI * Math.Pow(valorDeXExercicio12, 2)}");

Console.WriteLine("\n13- Considere o seguinte trecho de código:\r\n" +
    "int y = 5 ;\r\n" +
    "y = (y++)+y+(++y); ou y = y++ + y + ++y;\r\n" +
    "Console.WriteLine(y);\nR: ");
y = 5;
y = (y++) + y + (++y);
Console.WriteLine($"O resultado de y será = {y}.\n" +
    $"y++ irá retornar 5 para depois incremetar 6,\n" +
    $"em seguida ++y incrementará de 6 para 7 (5+6+7)");

Console.WriteLine("\n14- Escreva um programa que solicite a temperatura em graus Celsius e converta para\r\n" +
    "Kelvin e Farhenheit usando as fórmulas a seguir:\r\n" +
    "- Converter para Kelvin => K = C + 273 ;\r\n" +
    "- Converter para Farhenheit => F = (C * 9) / 5 + 32 ;");
Console.WriteLine("Informe a temperatura em graus Celsius ºC");
double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
double celsiusParaKelvin = temperaturaCelsius + 273;
double celsiusParaFarhenheit = (temperaturaCelsius * 9) / 5 + 32;
Console.WriteLine($"Temperatura em K: {celsiusParaKelvin}");
Console.WriteLine($"Temperatura em F: {celsiusParaFarhenheit}");

Console.WriteLine("\n15 - Escolha a opção que representa a exibição do resultado para o código usando os\r\n" +
    "operadores de decremento e incremento (pré e pós) :");
Console.WriteLine("\nvar numero = 5;\r\n" +
    "Console.WriteLine(numero++);\r\n" +
    "numero = 1;\r\n" +
    "Console.WriteLine(++numero);\r\n" +
    "numero = 2;\r\n" +
    "Console.WriteLine(numero--);\r\n" +
    "numero = 3;\r\n" +
    "Console.WriteLine(--numero);\r\n" +
    "Console.ReadKey();");
Console.WriteLine("(x) () () ()\n5 6 5 6\r\n2 3 2 2\r\n2 2 1 1\r\n2 2 2 3");

Console.ReadKey();