using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace TrabalhoImplex
{
    public class Program
    {       
        static void Main(string[] args)
        {            
            int[] numeros = new int[10];
            Random random = new Random();
            Temporizador temp = new Temporizador();
            int l = numeros[0];
            int r = numeros[10 - 1];
            int n = numeros.Length;
            

            TipoArray.VetorRandomico(numeros, random, 0, 10, 10);
            Console.WriteLine("[ [RANDOM] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                TipoArray.VetorRandomico(numeros, random, 0, 10, 10);
                Temporizador.ImprimirTemporizador(numeros);
            }

            Console.WriteLine("[ [REVERSE] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            
            TipoArray.VetorReverso(numeros, 0, 10, 10);
            Temporizador.ImprimirTemporizador(numeros);

            Console.WriteLine("[ [SORTED] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            TipoArray.VetorOrdenado(numeros, 0, 10);
            Temporizador.ImprimirTemporizador(numeros);

            Console.WriteLine("[ [NEARLY SORTED] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            
        }

    }
}
