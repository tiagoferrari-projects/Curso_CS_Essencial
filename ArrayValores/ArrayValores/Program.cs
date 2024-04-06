using System;

////Projeto ArrayValores
//Faça um programa que construa um vetor (array) de 8 posições de numeros inteiros armazenando em sua primeira posição o valor de 10, na segunda posição, o dobro do valor da primeira posição, 20, na terceira posição o dobro do valor da segunda posição, 40, e assim por diante. Ao final, mostre o valor armazenado na 8a posição e a soma de todos os valores armazenados do vetor.

namespace ArrayValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Bem vindo ao programa ArrayValores --");

            const int TAMANHOARRAY = 8;

            int[] numerosInteiros = new int[TAMANHOARRAY];

            numerosInteiros[0] = 10;
            int somaNumeros = numerosInteiros[0];

            for (int i = 1; i < TAMANHOARRAY; i++)
            {
                numerosInteiros[i] = numerosInteiros[i - 1] * 2;
                somaNumeros += numerosInteiros[i];
            }

            Console.WriteLine($"Valor na {TAMANHOARRAY}ª posição: {numerosInteiros[TAMANHOARRAY - 1]}");
            Console.WriteLine($"A Soma de todos os números é: {somaNumeros}");


            Console.WriteLine("-- Digite ENTER para SAIR --");
        }
    }
}
