using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TrabalhoImplex
{
    public class Temporizador
    {
        /*Tem várias formas de temporizar em c#. A forma que esta comentda é por médoto.
         Em um cenário típico, você chama o método e, em seguida, eventualmente chama 
        o método e, em seguida, verifica o tempo Stopwatch Start Stop decorrido usando 
        a Elapsed propriedade . outra forma é através do DateTime que pode trazer valor específico*/
        //public static void TemporizarBubble(int[] numeros)
        //{
        //    Stopwatch sw = new Stopwatch();

        //    //// Começa a contar o tempo
        //    //sw.Start();
        //    //// *** Executa a sua rotina ***
        //    //Algoritimos.OrdenarBubble(numeros);
        //    //// Para de contar o tempo
        //    //sw.Stop();
        //    //TimeSpan ts = sw.Elapsed;

        //    //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        //    //Console.WriteLine("Tempo Bubble " + elapsedTime);

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarBubble(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);

        //}

        //public static void TemporizarSelection(int[] numeros)
        //{
        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarSelection(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}
        //public static void TemporizarInserction(int[] numeros)
        //{

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarInsertion(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}

        //public static void TemporizarMerge(int[] numeros)
        //{
        //    int l = numeros[0];
        //    int r = numeros[10 - 1];
        //    int n = numeros.Length;
        //    //Stopwatch sw = new Stopwatch();

        //    //// Começa a contar o tempo
        //    //sw.Start();
        //    //// *** Executa a sua rotina ***
        //    //Algoritimos.OrdenarMerge(numeros, l, r);
        //    //// Para de contar o tempo
        //    //sw.Stop();
        //    //TimeSpan ts = sw.Elapsed;

        //    //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        //    //Console.WriteLine("Tempo Merge " + elapsedTime);

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarMerge(numeros, l, r);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);

        //}

        //public static void TemporizarHeap(int[] numeros)
        //{
        //    //Stopwatch sw = new Stopwatch();

        //    //// Começa a contar o tempo
        //    //sw.Start();
        //    //// *** Executa a sua rotina ***
        //    //Algoritimos.OrdenarHeapsort(numeros);
        //    //// Para de contar o tempo
        //    //sw.Stop();
        //    //TimeSpan ts = sw.Elapsed;

        //    //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        //    //Console.WriteLine("Tempo Heap " + elapsedTime);

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarHeapsort(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}

        //public static void TemporizarQuick(int[] numeros)
        //{
        //    int l = numeros[0];
        //    int r = numeros[10 - 1];

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarQuicksort(numeros, l, r);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}
        //public static void TemporizaBuck(int[] numeros)
        //{
        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarBucketSort(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}

        //public static void TemporizaRadix(int[] numeros)
        //{
        //    int n = numeros.Length;

        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarRadixSort(numeros, n);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}

        //public static void TemporizaCount(int[] numeros)
        //{
        //    DateTime start = DateTime.Now;
        //    Algoritimos.OrdenarCountingSort(numeros);
        //    DateTime end = DateTime.Now;

        //    TimeSpan ts = (end - start);
        //    Console.WriteLine("{0} ", ts.TotalMilliseconds);
        //}

        public static void ImprimirTemporizador(int[] numeros)
        {
            int l = numeros[0];
            int r = numeros[10 - 1];
            int n = numeros.Length;

            DateTime start = DateTime.Now;
            Algoritimos.OrdenarBubble(numeros);
            DateTime end = DateTime.Now;
            TimeSpan ob = (end - start);


            DateTime i = DateTime.Now;
            Algoritimos.OrdenarSelection(numeros);
            DateTime f = DateTime.Now;
            TimeSpan os = (f - i);


            DateTime p = DateTime.Now;
            Algoritimos.OrdenarInsertion(numeros);
            DateTime s = DateTime.Now;
            TimeSpan oi = (s - p);
           

            DateTime a = DateTime.Now;
            Algoritimos.OrdenarMerge(numeros, l, r);
            DateTime b = DateTime.Now;
            TimeSpan om = (b - a);
            

            DateTime c = DateTime.Now;
            Algoritimos.OrdenarHeapsort(numeros);
            DateTime d = DateTime.Now;
            TimeSpan oh = (d - c);

            DateTime e = DateTime.Now;
            Algoritimos.OrdenarQuicksort(numeros, l, r);
            DateTime fg = DateTime.Now;
            TimeSpan oq = (fg - e);
            


            DateTime h = DateTime.Now;
            Algoritimos.OrdenarBucketSort(numeros);
            DateTime ij = DateTime.Now;
            TimeSpan obu = (ij - h);
            

            DateTime k = DateTime.Now;
            Algoritimos.OrdenarRadixSort(numeros, n);
            DateTime m = DateTime.Now;
            TimeSpan or = (m - k);            

            DateTime o = DateTime.Now;
            Algoritimos.OrdenarCountingSort(numeros);
            DateTime q = DateTime.Now;
            TimeSpan oc = (q - o);

            Console.WriteLine("{0}\t {1}\t {2}\t{3}\t {4}\t{5}\t{6}\t{7}\t{8}\t{9}", 
                numeros.Length,
                ob.TotalMilliseconds,
                ob.TotalMilliseconds,
                os.TotalMilliseconds, 
                oi.TotalMilliseconds, 
                om.TotalMilliseconds,
                oh.TotalMilliseconds,
                oq.TotalMilliseconds,
                obu.TotalMilliseconds,
                or.TotalMilliseconds,
                oc.TotalMilliseconds);

        }
    }
}
