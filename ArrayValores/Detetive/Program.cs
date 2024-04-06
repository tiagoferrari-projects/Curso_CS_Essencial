using System;
using System.Collections.Generic;
using System.Linq;


namespace Detetive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que faça 5 perguntas para uma pessoa sobre um crime.As perguntas são:
            //• "Telefonou para a vítima?"
            //• "Esteve no local do crime?"
            //• "Mora perto da vítima?"
            //• "Devia para a vítima?"
            //• "Já trabalhou com a vitima?"
            //O programa deve, no final, emitir uma classificação sobre a participação da pessoa no crime.Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino".
            //Caso contrário, ele será classificado como "Inocente".*/

            Console.WriteLine("-- Bem vindo ao programa Detetive");

            List<string> perguntasCruciais = new List<string>(5);

            Console.WriteLine("Responda ao questionário ");
            Console.WriteLine("Telefonou para a vítima?");
            perguntasCruciais.Add(Console.ReadLine().ToLower());
            Console.WriteLine("Esteve no local do crime?");
            perguntasCruciais.Add(Console.ReadLine().ToLower());
            Console.WriteLine("Mora perto da vítima?");
            perguntasCruciais.Add(Console.ReadLine().ToLower());
            Console.WriteLine("Devia para a vítima?");
            perguntasCruciais.Add(Console.ReadLine().ToLower());
            Console.WriteLine("Já trabalhou com a vitima?");
            perguntasCruciais.Add(Console.ReadLine().ToLower());

            int contadorSuspeito = 0;

            for(int i = 0; i < perguntasCruciais.Count; i++)
            {
                if (perguntasCruciais[i].Contains('s'))
                    contadorSuspeito++;
            }

            if (contadorSuspeito == 2)
                Console.WriteLine("O indivíduo é Suspeito!");
            else if (contadorSuspeito == 5)
                Console.WriteLine("O indivíduo é o Assassino!");
            else if (contadorSuspeito == 3 || contadorSuspeito == 4)
                Console.WriteLine("O indivíduo é Cúmplice");
            else if (contadorSuspeito == 0 || contadorSuspeito == 1)
                Console.WriteLine("O indivíduo é inocente");
            else
                Console.WriteLine("Inválido. Tente novamente!!");


            #region "Resolução Professor"

            //string[] perguntinhas = {
            //    "Telefonou para a vítima? | SIM = 1 NÃO = 0:",
            //    "Esteve no local do crime? | SIM = 1 NÃO = 0:",
            //    "Mora perto da vítima? | SIM = 1 NÃO = 0:",
            //    "Devia para a vítima? | SIM = 1 NÃO = 0:",
            //    "Já trabalhou com a vítima? | SIM = 1 NÃO = 0:"
            //};

            //string[] veredicto = {
            //    "Inocente",
            //    "Inocente",
            //    "Suspeito",
            //    "Cumplice",
            //    "Cumplice",
            //    "Assasino"
            //};

            //int contadorRespostas = 0;

            //for (int i = 0; i < perguntinhas.Length; i++)
            //{
            //    Console.Write($"{perguntinhas[i]}");
            //    contadorRespostas += int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"{veredicto[contadorRespostas]}");

            #endregion

            Console.WriteLine("-- Digite ENTER para sair -- ");
        }
    }
}
