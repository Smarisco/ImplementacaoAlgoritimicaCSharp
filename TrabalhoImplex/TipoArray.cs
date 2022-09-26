using System;
using System.Linq;

namespace TrabalhoImplex
{
    public class TipoArray
    {
        public static void VetorRandomico(int[] numeros, Random random, int inicio, int fim, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                //gera numero aleatório dentro de um intervalo diferente de 10 em 10
                numeros[i] = random.Next(inicio, fim);
                numeros.Take(10).Skip(10);
            }
        }
        public static void VetorReverso(int[] numeros, int inicio, int fim, int tamanho)
        {
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = random.Next(inicio, fim);
                numeros.Take(10).Skip(10);
            }
            Array.Reverse(numeros);

        }

        public static void VetorOrdenado(int[] numeros, int inicio, int fim)
        {
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(inicio, fim);
                numeros.Take(10).Skip(10);
            }
            Array.Sort(numeros);
        }

        public static void VetorQuaseOrdenado(int[] numeros, int inicio, int fim)
        {
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(inicio, fim);
                numeros.Take(10).Skip(10);
            }
            Array.Sort(numeros);
        }
    }
}
