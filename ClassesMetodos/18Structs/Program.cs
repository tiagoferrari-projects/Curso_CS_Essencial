Console.WriteLine("## Structs ##\n");

//Cliente cliente = new Cliente();
//cliente.Nome = "Maria";
//cliente.Idade = 19;
//Console.WriteLine($"{cliente.Nome} - {cliente.Idade}");

MinhaClasse minhaClasse1 = new (), minhaClasse2 = null;
MinhaStruct minhaStruct1 = new (), minhaStruct2 = new ();

minhaClasse1.x = minhaStruct1.x = 5;
minhaClasse1.y = minhaStruct1.y = 10;

//Console.WriteLine($"minhaClasse2.x = {minhaClasse2.x}");
//Console.WriteLine($"minhaClasse2.y = {minhaClasse2.y}");
//Console.WriteLine($"minhaStruct2.x = {minhaStruct2.x}");
//Console.WriteLine($"minhaStruct2.y = {minhaStruct2.y}");

minhaClasse2 = minhaClasse1; //referência
minhaStruct2 = minhaStruct1; //valor

Console.WriteLine($"minhaClasse1.x = {minhaClasse1.x}");
Console.WriteLine($"minhaClasse1.y = {minhaClasse1.y}");
Console.WriteLine($"minhaClasse2.x = {minhaClasse2.x}");
Console.WriteLine($"minhaClasse2.y = {minhaClasse2.y}");

Console.WriteLine($"minhaStruct1.x = {minhaStruct1.x}");
Console.WriteLine($"minhaStruct1.y = {minhaStruct1.y}");
Console.WriteLine($"minhaStruct2.x = {minhaStruct2.x}");
Console.WriteLine($"minhaStruct2.y = {minhaStruct2.y}");


Console.ReadKey();

//public struct Cliente
//{
//    public string? Nome {  get; set; }
//    public int Idade {  get; set; }

//    public Cliente(string? nome, int idade)
//    {
//        Nome = nome;
//        Idade = idade;
//    }
//}

public struct MinhaStruct
{
    public int x;
    public int y;
}

public class MinhaClasse
{
    public int x;
    public int y;
}

