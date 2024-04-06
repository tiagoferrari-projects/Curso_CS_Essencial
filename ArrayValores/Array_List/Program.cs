using System;
using System.Collections;


namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          * Quais as características de um array
          - conjunto de valores adjacentes em memória
          - tamanho fixo(alocação estática)
          - stack armazena um endereço(não um valor)
          - acesso por índice(deslocamento de endereço)
          - armazenamento é de um único tipo de dado mediante a sua declaração.
           ----------------------------------------------------------------------
          * Se eu precisar de mais itens além dos que foram alocados inicialmente?
          *    Criar um conjunto novo e recuperar os dados do conjunto anterior
          * Se eu não utilizar todos os itens (posições) alocadas em memória?
          *    Desperdício de memória.
         */

            ArrayList fruteira = new ArrayList();
            /* List => Alocação dinâmica do ponto de vista (programador)
             *      Parece dinâmica, mas eu vou provar que não é.
             * ArrayList => pode armazenar tipos de dados diferentes :( (boxing - unboxing)
             * Qual o tipo de dado de um ArrayList ? Qualquer tipo...C# qualquer tipo (Object)
             * 1 => int => adicionar no ArrayList => Add(1) => 1 inteiro é convertido para object
             *              Agora tipo object e se ele é objeto => heap
             *              Agora ele não é mais um valor, agora é um objeto (qualquer coisa).
             */

            Console.WriteLine("Quantos valoes você quer digita?");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDigitado; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                fruteira.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
