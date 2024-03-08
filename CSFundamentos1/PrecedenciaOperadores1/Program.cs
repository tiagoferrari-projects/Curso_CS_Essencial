Console.WriteLine("## Precedência de Operadores ##\n");

//int x = 10 - 2 * 3;
//Console.WriteLine(x);

//bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
//bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
//Console.WriteLine(b);

//int a = 5, b = 6, c = 4;
//int r = --a * b - ++c;
//Console.WriteLine(r);


// o valor de c (ou seja, 3)é atribuído a b, e então o valor de b é atribuído a a.
// depois de executar esta instrução, os valores de a, b e c serão igual a 3.
int a = 5, b = 6, c = 3;
int resultado = a = b = c;
Console.WriteLine(resultado);



Console.ReadKey();
