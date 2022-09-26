using System;

namespace TrabalhoImplex
{
    public class TipoArray
    {
        public static void VetorRandomico(int[] numeros, Random random, int inicio, int fim, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                //gera numero aleatório dentro de um intervalo diferente
                numeros[i] = random.Next(inicio, fim);
            }
        }
        public static void VetorReverso(int[] numeros, int inicio, int fim, int tamanho)
        {
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = random.Next(inicio, fim);
            }
            Array.Reverse(numeros);

        }

        public static void VetorOrdenado(int[] numeros, int inicio, int fim)
        {
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(inicio, fim);
            }
            Array.Sort(numeros);
        }

        public static void VetorQuaseOrdenado(int[] numeros, int inicio, int fim)
        {
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(inicio, fim);
            }
            Array.Sort(numeros);
        }
    }
}
