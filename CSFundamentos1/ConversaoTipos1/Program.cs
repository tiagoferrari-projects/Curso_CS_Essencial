Console.WriteLine("## Conversão de Tipos ##\n");
Console.WriteLine("Conversões Implícitas");
// byte -> 1 byte
// short -> 2 bytes
// int -> 4 bytes
// long -> 8 bytes
// float -> 4 bytes
// double -> 8 bytes
// decimal -> 16 bytes

//int varInt = 100;
//double varDouble = varInt;
//Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

Console.WriteLine("Conversões Explícitas");
double varDouble = 12.456;      // 8 bytes
int varInt = (int)varDouble;    // 4 bytes (perda de precisão)
Console.WriteLine(varDouble);
Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;
float resultado = (float) num1 / num2;

Console.WriteLine(resultado);

Console.ReadLine();