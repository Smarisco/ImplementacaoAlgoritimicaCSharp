using System;

namespace TrabalhoImplex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Temporizador temp = new Temporizador();

            Console.WriteLine("Insira o tipo de vetor que deseja.");
            Console.WriteLine("1.Vetor Randomico.");
            Console.WriteLine("2. Vetor Reverso.");
            Console.WriteLine("3.Vetor Ordenado.");
            Console.WriteLine("4.Vetor Quase - Ordenado.");

            string tipoVetor;
            int[] numeros = new int[10];
            int tamanho = 10;
            int inicio = numeros[0];
            int fim = numeros[tamanho - 1];


            tipoVetor = Console.ReadLine();
            if (tipoVetor == "1")
            {
                Console.WriteLine("[ [RANDOM] ]");
                Console.WriteLine();
                Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < 5; i++)
                {
                    TipoArray.VetorRandomico(numeros, random, inicio, fim, tamanho);
                    Temporizador.ImprimirTemporizador(numeros);
                }
            }

            if (tipoVetor == "2")
            {

                Console.WriteLine("[ [REVERSE] ]");
                Console.WriteLine();
                Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < 5; i++)
                {
                    TipoArray.VetorReverso(numeros, inicio, fim, tamanho);
                    Temporizador.ImprimirTemporizador(numeros);
                }
            }
            if (tipoVetor == "3")
            {

                Console.WriteLine("[ [SORTED] ]");
                Console.WriteLine();
                Console.WriteLine("n\t Bubble\t Selection\tInsertion\t Merge\tHeap\tQuick\tCounting\tRadix\tBucket");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < 5; i++)
                {
                    TipoArray.VetorOrdenado(numeros, inicio, fim);
                    Temporizador.ImprimirTemporizador(numeros);
                }
            }
            if (tipoVetor == "4")
            {

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

            if(tipoVetor!="1" && tipoVetor != "2" && tipoVetor != "3" && tipoVetor != "4")
            {
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
}

