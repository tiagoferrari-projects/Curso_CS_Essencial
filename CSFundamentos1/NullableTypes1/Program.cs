using System.Runtime.InteropServices;

Console.WriteLine("## Nullable Types ##\n");
Console.WriteLine();

// declaração simplificada
// int? i = null;
// double? d = null;
// bool? b = null;

// declaração com tipo Nullable
// Nullable<int> i = null;
// Nullable<double> d = null;
// Nullable<bool> b = null;

// Console.WriteLine(i);
// Console.WriteLine(d);
// Console.WriteLine(b);

// operador de coalescência nula ??
// int? x = 1;
// int? x = null;
// int y = x ?? 0;
// Console.WriteLine(y);

// int? x = 4;
// int? y = 3;
// int? z = x * y;
// Console.WriteLine(z);

 int? b = null;
// int? b = 100;

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}

Console.ReadKey();