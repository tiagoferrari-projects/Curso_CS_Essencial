using System;
using System.Collections.Generic;
using System.Linq;


namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha1 = new Stack<int>();

            pilha1.Push(1);
            pilha1.Push(8);
            pilha1.Push(9);
            pilha1.Push(-80);

            int x = pilha1.ElementAt(0);
            int y = pilha1.Pop();

            List<int> lista = new List<int>();
            lista.Insert(0, 1);
            lista.Insert(0, 8);
            lista.Insert(0, 9);
            lista.Insert(0, -80);
            
            lista[2] = 5;

            lista.RemoveAt(0);
        }
    }
}
