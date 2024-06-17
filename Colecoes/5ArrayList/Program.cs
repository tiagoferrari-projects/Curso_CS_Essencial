using System.Collections;

#region "ArrayList 01"
//Console.WriteLine("## ArrayList\n##");

//ArrayList lista;
//lista = new ArrayList();

//ArrayList lista1 = new ArrayList();
//var lista2 = new ArrayList();
//ArrayList lista3 = new();

//ArrayList lista4 = new ArrayList(5);
//var lista5 = new ArrayList(5);
//ArrayList lista6 = new(5);

//ArrayList lista7 = new();
//lista7.Add("Paulo");
//lista7.Add(4.5);
//lista7.Add(5);
//lista7.Add(true);
//lista7.Add(" ");
//lista7.Add(null);

//var lista8 = new ArrayList() { "Paulo", 4.5, 5, true, " ", null };
#endregion

#region "ArrayList 02"

//var lista = new ArrayList() { "Maria", 5, true, " ", null };
//lista.Add(3.5);
//lista.Insert(2, "Paulo");

var lista = new ArrayList() { "Maria", 5, true };
int[] array1 = { 1, 2, 3, };

lista.AddRange(array1);
lista.InsertRange(2, array1);

#endregion



Console.ReadKey();