using _11Indexadores;

Console.WriteLine("## Indexadores ##\n");

Time time = new Time();

// atribui valores
time[1] = "Corinthians";
time[3] = "Real Madrid";
time[5] = "Manchester City";
time[7] = "Liverpool";
time[-1] = "Milan";
time[1000] = "Chelsea";

// obtendo valores
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[1000];

// exibir
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);    
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);


Console.ReadKey();