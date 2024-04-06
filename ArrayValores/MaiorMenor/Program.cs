using System;

//Projeto: MaiorMenor
//Faça um programa que determine o maior e o menor dentre N numero. A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar calculando o maior e o menor até que a entrada seja igual a 0 (ZERO). No entanto no final desse programa, apresente os números lidos, o maior e o menor numero. O usuário poderá digitar no máximo até 100 números.

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa MAIOR/MENOR");

            const int LIMITENUMEROS = 5; // 100
            int[] numeros = new int[LIMITENUMEROS];
            int contador = 0;

            int menorValor = int.MaxValue;
            int maiorValor = int.MinValue;

            do
            {
            
                Console.WriteLine("Digite um número inteiro ou 0 para sair: ");
                numeros[contador] = int.Parse(Console.ReadLine());

                if (numeros[contador] == 0)
                    break;

                if (numeros[contador] > maiorValor)
                    maiorValor = numeros[contador];

                if(numeros[contador] < menorValor)
                    menorValor = numeros[contador];

                contador++;
            } while (contador < LIMITENUMEROS);

            if(contador > 0)
            {
                Console.Write($"O maior número digitado foi {maiorValor}\n");
                Console.Write($"O maior número digitado foi {menorValor}\n");

                for (int i = 0; i < contador; i++)
                {
                    Console.Write($"{numeros[i]} - ");
                }

                //foreach (int numero in numeros)
                //{
                //    if (numero == 0)
                //        break;
                //    Console.WriteLine($"{numero} - ");
                //}
            }else
                Console.WriteLine("Nenhum valor foi informado.");

            Console.WriteLine("-- Digite ENTER para SAIR");
            Console.ReadLine();
        }
    }
}
