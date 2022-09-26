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
            int tamanho = 10;
            int inicio = numeros[0];
            int fim = numeros[tamanho - 1];
            
            
            
            Console.WriteLine("[ [RANDOM] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                TipoArray.VetorRandomico(numeros, random, inicio, fim, tamanho);
                Temporizador.ImprimirTemporizador(numeros);
            }

            Console.WriteLine("[ [REVERSE] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            
            for (int i = 0; i < 5; i++)
            {
                TipoArray.VetorReverso(numeros, inicio, fim, tamanho);
            Temporizador.ImprimirTemporizador(numeros);
            }

            Console.WriteLine("[ [SORTED] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {
                TipoArray.VetorOrdenado(numeros, inicio, fim);
                Temporizador.ImprimirTemporizador(numeros);
            }

            Console.WriteLine("[ [NEARLY SORTED] ]");
            Console.WriteLine();
            Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                TipoArray.VetorQuaseOrdenado(numeros, inicio, fim);
                Temporizador.ImprimirTemporizador(numeros);
            }

        }

    }
}
