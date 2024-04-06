using System;
using System.Collections.Generic;


namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fruteira = new List<int>(3);

            Console.WriteLine("Quantos valores você quer digitar?");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for(int i = 0; i < numeroDigitado; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                fruteira.Add(int.Parse(Console.ReadLine()));
            }

            fruteira.Insert(2, 150);

            bool x = fruteira.Remove(2);
            if(x == true)
                Console.WriteLine("Número removido da lista");
            else
                Console.WriteLine("Número removido da lista");

            fruteira.RemoveAt(2);

            Console.WriteLine("-- Digite ENTER para sair --");
            Console.ReadLine();
        }
    }
}
