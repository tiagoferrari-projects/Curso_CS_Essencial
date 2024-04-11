using System;


namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Inicio --");

            Console.WriteLine("Digite um numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            int numero2 = int.Parse(Console.ReadLine());

            Soma(numero1, numero2);

            PularLinha(); // a ação de uma função dentro do main é chamada "Invocar"

            Console.WriteLine("-- Meio --");

            Console.WriteLine("Quer pular quantas linhas, por gentileza?");
            int pularLinhas = int.Parse(Console.ReadLine());
            
            PularLinhas(pularLinhas);

            Console.WriteLine("-- Fim --");

            Console.WriteLine("-- Digite ENTER para sair -- ");
            Console.ReadLine();
        }

        static void PularLinha()
        {
            for (int i = 0; i < 1; i++)
                Console.WriteLine();
        }

        static void PularLinhas( int linhasParaPular)
        {
            for (int i = 0; i < linhasParaPular; i++)
                Console.WriteLine();
        }

        static int Soma(int z, int x)
        {
            return z + x;
        }
    }
}
