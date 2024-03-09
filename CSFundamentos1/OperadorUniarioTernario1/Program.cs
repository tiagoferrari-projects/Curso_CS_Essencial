Console.WriteLine("## Uniário e Ternário ##\n");

//int positivo = 1;
//int resultado;

//resultado = +positivo;
//Console.WriteLine(resultado);

//Console.WriteLine("Informe o número: \n");
//var n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O negativo de {n} é {-n}");
//--------------------------------------------------
//Console.WriteLine("informe a temperatura: \n");
//var temp = Convert.ToDouble(Console.ReadLine());

//var resultado = temp > 27 ? "Quente" : "Normal";
//Console.WriteLine($"O tempo esta {resultado}");
//---------------------------------------------------
Console.WriteLine("Informe o valor de x: \n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: \n");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(resultado);

Console.ReadKey();