Console.WriteLine("## Conversão de Tipos ##\n");
Console.WriteLine("Conversões Implícitas");
// byte -> 1 byte
// short -> 2 bytes
// int -> 4 bytes
// long -> 8 bytes
// float -> 4 bytes
// double -> 8 bytes
// decimal -> 16 bytes

int varInt = 100;
double varDouble = varInt;
Console.WriteLine(varDouble);

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
double varDouble = 12.456;
int varInt = (int)


Console.ReadLine();