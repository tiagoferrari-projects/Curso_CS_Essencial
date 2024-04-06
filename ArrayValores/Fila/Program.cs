using System;
using System.Collections.Generic;
using System.Linq;


namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila1 = new Queue<int>();

            fila1.Enqueue(1);
            fila1.Enqueue(8);
            fila1.Enqueue(9);
            fila1.Enqueue(-80);

            int x = fila1.ElementAt(0);
            //int y = fila1.Enqueue(8);

            //maneira simplificada
            List<int> lista = new List<int>
            {
                1,
                8,
                9,
                -80
            };
            
            lista[2] = 5;

            lista.RemoveAt(0);
        }
    }
}
