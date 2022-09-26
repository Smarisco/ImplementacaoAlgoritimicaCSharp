using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoImplex
{
    public class Algoritimos
    {
        //Impelementando BucketSort
        public static void OrdenarBucketSort(int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }

        // Implementando RadixSort

        public static int GetMax(int[] numeros, int n)
        {
            int mx = numeros[0];
            for (int i = 1; i < n; i++)
                if (numeros[i] > mx)
                    mx = numeros[i];
            return mx;
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            for (i = 0; i < 10; i++)
                count[i] = 0;

            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;


            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            //Construindo Array de saída
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void OrdenarRadixSort(int[] numeros, int n)
        {

            int m = GetMax(numeros, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(numeros, n, exp);
        }

        //Implementando CountigSorting
        public static void OrdenarCountingSort(int[] numeros)
        {
            int n = numeros.Length;

            int[] output = new int[n];
            int[] count = new int[256];

            for (int i = 0; i < 256; ++i)
                count[i] = 0;

            for (int i = 0; i < n; ++i)
                ++count[numeros[i]];

            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[numeros[i]] - 1] = numeros[i];
                --count[numeros[i]];
            }

            for (int i = 0; i < n; ++i)
                numeros[i] = output[i];
        }

        // iniciando o algoritimo quicksort
        public static void Troca(int[] numeros, int i, int j)
        {
            int aux = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = aux;
        }

        /* Esta função toma o último elemento como pivô, coloca o elemento pivô em sua posição correta em
             array, e coloca tudo menor (menor que pivô) à esquerda do pivô e todos os elementos maiores à direita de pivô */
        public static int Particao(int[] numeros, int low, int high)
        {
            int pivot = numeros[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (numeros[j] < pivot)
                {
                    i++;
                    Troca(numeros, i, j);
                }
            }
            Troca(numeros, i + 1, high);
            return (i + 1);
        }

        public static void OrdenarQuicksort(int[] numeros, int low, int high)
        {
            if (low < high)
            {
                int pi = Particao(numeros, low, high);

                OrdenarQuicksort(numeros, low, pi - 1);
                OrdenarQuicksort(numeros, pi + 1, high);
            }
        }
        public static void OrdenarHeapsort(int[] numeros)
        {
            int N = numeros.Length;

            for (int i = N / 2 - 1; i >= 0; i--)
                Heapsort(numeros, N, i);

            for (int i = N - 1; i > 0; i--)
            {
                int temp = numeros[0];
                numeros[0] = numeros[i];
                numeros[i] = temp;
                Heapsort(numeros, i, 0);
            }
        }

        //iniciando o algoritimo Heapsort
        public static void Heapsort(int[] numeros, int N, int i)
        {
            int largest = i; // Inicializar maior com root
            int l = 2 * i + 1;
            int r = 2 * i + 2;


            if (l < N && numeros[l] > numeros[largest])
                largest = l;

            if (r < N && numeros[r] > numeros[largest])
                largest = r;

            if (largest != i)
            {
                int swap = numeros[i];
                numeros[i] = numeros[largest];
                numeros[largest] = swap;
                Heapsort(numeros, N, largest);
            }
        }

        //inicializando MergeSort
        public static void Merge(int[] numeros, int l, int m, int r)
        {
            // Encontra tamanhos de dois
            // subarrays a serem mesclados
            int n1 = m - l + 1;
            int n2 = r - m;

            // Criar matrizes temporárias
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copiar dados para matrizes temporárias
            for (i = 0; i < n1; ++i)
                L[i] = numeros[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = numeros[m + 1 + j];


            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    numeros[k] = L[i];
                    i++;
                }
                else
                {
                    numeros[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copia de Elementos restantes
            while (i < n1)
            {
                numeros[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                numeros[k] = R[j];
                j++;
                k++;
            }
        }

        public static void OrdenarMerge(int[] numeros, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                OrdenarMerge(numeros, l, m);
                OrdenarMerge(numeros, m + 1, r);
                Merge(numeros, l, m, r);
            }
        }

        public static void OrdenarInsertion(int[] numeros)
        {

            for (int i = 0; i < numeros.Length; i++)
            {
                int aux = numeros[i];
                int j = i - 1;

                while (j >= 0 && numeros[j] > aux)
                {
                    numeros[j + 1] = numeros[j];
                    j = j - 1;
                }
                numeros[j + 1] = aux;
            }
        }

        public static void OrdenarSelection(int[] numeros)
        {
            int minIndex;
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                //assumimos que o primeiro elemento é min
                minIndex = i;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] < numeros[minIndex])
                    {
                        //encontramos novo valor min
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int aux = numeros[minIndex];
                    numeros[minIndex] = numeros[i];
                    numeros[i] = aux;
                }

            }
        }

        public static void OrdenarBubble(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }

                }
            }
        }

    }
}
