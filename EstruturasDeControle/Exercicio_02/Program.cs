Console.WriteLine(" -- EXERCÍCIO 02 --");

Console.WriteLine("\n2- Escreva um programa para calcular a raiz da equação quadrática : ax² + bx + c = 0" +
    "\r\n- Considere a, b e c números inteiros (positivos, negativos e o zero);" +
    "\r\n- Para calcular as raízes use a fórmula de Báskara;" +
    "\r\n- Solicite a entrada de a , b e c e informe se existe ou não raiz real;" +
    "\r\nDica: Utilize os recursos da classe Math e use a instrução if-else-if.");

//Modelos de Saída
//Cálculo da equação do segundo grau (ax^2+bx+c) :
//Informe o valor de a : 2
//Informe o valor de b : 3
//Informe o valor de c : 4
//As raízes são imaginárias;
//Sem solução para os números reais.

//Cálculo da equação do segundo grau (ax^2+bx+c) :
//Informe o valor de a : 1
//Informe o valor de b : -1
//Informe o valor de c : -12
//Ambas as raízes são reais e diferentes
//Primeira raiz x1= 4
//Segunda raiz x2= -3

Console.Write("\nInforme o valor de a: \t");
int valorDeA = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de b: \t");
int valorDeB = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de c: \t");
int valorDeC = Convert.ToInt32(Console.ReadLine());

double valorDoDelta = Math.Pow(valorDeB, 2) - (4 * valorDeA * valorDeC);
double valorDeX1 = (-valorDeB + Math.Sqrt(valorDoDelta)) / 2 * valorDeA;
double valorDeX2 = (-valorDeB - Math.Sqrt(valorDoDelta)) / 2 * valorDeA;

if (valorDoDelta < 0)
    Console.WriteLine("\nAs raízes são imaginárias.\nSem solução para os números reais.");
else if (valorDoDelta == 0)
{
    Console.WriteLine("As duas raízes são iguais:");
    Console.WriteLine($"Primeira raíz x1 = {valorDeX1:0.00}");
    Console.WriteLine($"Segunda raíz x2 = {valorDeX2:0.00}");
}
else
{
    Console.WriteLine("As duas raízes são diferentes:");
    Console.WriteLine($"Primeira raíz x1 = {valorDeX1:0.00}");
    Console.WriteLine($"Segunda raíz x2 = {valorDeX2:0.00}");
}

Console.Write("\nDigite ENTER para sair");
Console.ReadKey();