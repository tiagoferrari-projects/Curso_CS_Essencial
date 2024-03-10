Console.WriteLine("## Instrução IF ##\n");

// primeira abordagem
//Console.WriteLine("Cliente Especial (S/N)");
//var resposta = Console.ReadLine().ToUpper();

//if (resposta == "S")
//    Console.WriteLine("Desconto de 10%");

// segunda abordagem
//Console.WriteLine("Cliente Especial (true/false)");
//var resposta = Convert.ToBoolean(Console.ReadLine());

//if (resposta)
//    Console.WriteLine("Desconto de 10%");

//Console.WriteLine("Fim do processamento!");

// terceira abordagem
Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
    Console.WriteLine("x é maior que y!!");
if(y > x)
    Console.WriteLine("y é maior que x!!");
if (y == x)
    Console.WriteLine("x é igual a y!!");

Console.ReadKey();