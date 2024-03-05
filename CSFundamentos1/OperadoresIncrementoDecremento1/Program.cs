Console.WriteLine("## Operadores Incremento e Decremento ##\n");

//// operador pos-incremento -> primeiro resolve depois incrementa
//int x = 0;
//Console.WriteLine($"x = {x}");

//int resultado1 = x++ + 10;
//Console.WriteLine($"pós-incremento ==> {resultado1}");
//Console.WriteLine($"valor de x ==> {x}\n");

//// operador pre-incremento -> primeiro incrementa depois resolve
//int y = 0;
//Console.WriteLine($"y = {y}");

//int resultado2 = ++y + 10;
//Console.WriteLine($"pré-incremento ==> {resultado2}");
//Console.WriteLine($"valor de y ==> {y}");

// operador pos-decremento -> primeiro resolve depois decrementa
int x = 0;
Console.WriteLine($"x = {x}");

int resultado1 = x-- + 10;
Console.WriteLine($"pós-decremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

// operador pre-decremento -> primeiro decrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");

int resultado2 = --y + 10;
Console.WriteLine($"pré-decremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}\n");


Console.ReadKey();
