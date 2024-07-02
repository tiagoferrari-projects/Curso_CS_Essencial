using System.Collections.Generic;

Console.WriteLine("## Coleção List##\n");

#region "Coleção List<T> I"
//// declarar uma coleção do tipo List<T>
//List<string> lista;
//lista = new List<string>();

//List<int> lista1 = new List<int>();
//var lista2 = new List<float>();
//List<double> lista3 = new();

//List<string> nomes = new();
//nomes.Add("Paulo");
//nomes.Add("Maria");

//var lista4 = new List<string>()
//{
//    "Paulo","Maria","Bia", "Pedro"
//};
#endregion

#region "Coleção List<T> II"

//var lista  = new List<string>() { "Maria","Ana", "Pedro","Carlos", "José"};

//lista.Add("Marta");
//lista.Insert(2, "Bia");

//Console.WriteLine($"{lista.Count} elementos");

//*************************************************************
//var lista = new List<string>() { "Maria", "Ana", "Pedro" };
//string[] array1 = {"Diná","Carlos","João"};
//lista.AddRange(array1);
//lista.InsertRange(1, array1);

//Console.WriteLine($"{lista.Count} itens");
//*************************************************************

//*************************************************************
//var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

//lista.Remove(7);
//lista.RemoveAt(4);
//lista.RemoveRange(0, 2);

//Console.WriteLine($"{lista.Count} itens");
//*************************************************************

//*************************************************************
//var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro"};

//acessar um elemento da lista usando indice
//var primeiro = lista[0];
//var quarto = lista[3];

//Console.WriteLine(primeiro);
//Console.WriteLine(quarto);

//lista[0] = "José";
//lista[3] = "Silvia";

//Console.WriteLine(lista[0]);
//Console.WriteLine(lista[3]);
//Console.WriteLine(lista[9]); // --- erro em tempo de execução:  System.ArgumentOutOfRangeException
//*************************************************************

//*************************************************************
//var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

//for (int i = 0; i < lista.Count; i++)
//{
//    Console.WriteLine(lista[i]);
//}

//foreach (var elemento in lista)
//{
//    Console.Write($"{elemento} ");
//}
//*************************************************************

//*************************************************************
//var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "José" };

//var res1 = lista.Contains("Ana");
//var res2 = lista.Contains("José");

//var res3 = lista.Contains("Ze");
//var res4 = lista.Contains("Mari");

//Console.WriteLine(lista.Contains("Pedro"));
//*************************************************************

//*************************************************************
//var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "José" };

//ExibirLista(lista);
//lista.Sort();
//ExibirLista(lista);

//lista.Clear();
//ExibirLista(lista);
//Console.WriteLine($"{lista.Count} itens");
//Console.WriteLine("FIM...");
//*************************************************************
#endregion

#region "List"

List<string> frutas = new List<string>() { "Uva","Banana", "Pera", "Maça", "Abacate","Laranja", "Morango"};

// método com predicado
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Predicado: {fruta1}");

//método utilizando função lambda
var fruta2 = frutas.Find(f => f.StartsWith('L'));
Console.WriteLine($"Expressão Lambda Find: {fruta2}");

var fruta3 = frutas.FindLast(f => f.StartsWith('n'));
Console.WriteLine($"Expressão Lambda FindLast: {fruta3}");

var fruta4 = frutas.FindIndex(f => f.Contains('n'));
Console.WriteLine($"Expressão Lambda FindIndex: index={fruta4} item={frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(f => f.Contains('n'));
Console.WriteLine($"Expressão Lambda FindLastIndex: index={fruta5} item={frutas[fruta5]}");

var frutas6 = frutas.FindAll(f => f.Contains('n'));
Console.Write("\nFindAll : ");
foreach (var item in frutas6)
{
    Console.Write($"{item} ");
}

#endregion

Console.ReadKey();

static void ExibirLista(List<string> lista)
{
    Console.WriteLine();
    foreach (var elemento in lista)
        Console.WriteLine(elemento);
}

static bool Procura(string item)
{
    return item.Contains('n');
}