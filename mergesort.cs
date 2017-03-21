using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace SortComparison
{
    class mergesort
    {
        private const int t = 40000;
        public int[] a = new int[t];
        Stopwatch sw = new Stopwatch();
        public void sort()
        {
            sw.Start();
            mergeSort(a);
            sw.Stop();
            Console.WriteLine("マージソートで並べ替えをした配列の百個目までを表示します。");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write("{0}" + " ", a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("実行時間は{0}ミリ秒です。", sw.ElapsedMilliseconds);

        }
        
        void merge(int[] a1, int[] a2, int[] a)
        {
            int i = 0, j = 0;
            while (i < a1.Length || j < a2.Length)
            {
                if (j >= a2.Length || (i < a1.Length && a1[i] < a2[j]))
                {
                    a[i + j] = a1[i];
                    i++;
                }
                else
                {
                    a[i + j] = a2[j];
                    j++;
                }
            }
        }
        void mergeSort(int[] a)
        {
            if (a.Length > 1)
            {
                int m = a.Length / 2;
                int n = a.Length - m;
                int[] a1 = new int[m];
                int[] a2 = new int[n];
                for (int i = 0; i < m; i++) a1[i] = a[i];
                for (int i = 0; i < n; i++) a2[i] = a[m + i];
                mergeSort(a1);
                mergeSort(a2);
                merge(a1, a2, a);
            }
        }

    }
}
