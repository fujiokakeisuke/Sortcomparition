using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace SortComparison
{
    class Sort
    {
        public int[] a;
        private int t;
        Stopwatch sw = new Stopwatch();
        public void sortstart()
        {
            sw.Start();
        }
        public void sortquit(string A) {
            sw.Stop();
            Console.WriteLine("{0}で並べ替えをした配列の100個目までを表示します。",A);
            for (int i = 0; i < 100; ++i)
            {
                Console.Write("{0}" + " ", a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("実行時間は{0}ミリ秒です。", sw.ElapsedMilliseconds);
        }
        public void bubblesort()
        {
            int k;
            for (int i = 0; i < t - 1; ++i)
            {
                for (int j = t - 1; i < j; --j)
                {
                    if (a[i] > a[j])
                    {
                        k = a[i]; a[i] = a[j]; a[j] = k;
                    }
                }
            }
        }

        public void merge(int[] a1, int[] a2, int[] a)
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
        public void mergeSort(int[] a)
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
        public void Quicksort(int[] a, int left, int right)
        {
            int last;
            int temp;
            if (left >= right)
            {
                return;
            }
            last = left;
            last = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (a[i] < a[left])
                {
                    last++;
                    temp = a[last];
                    a[last] = a[i];
                    a[i] = temp;
                }
            }

            temp = a[left];
            a[left] = a[last];
            a[last] = temp;

            Quicksort(a, left, last - 1);
            Quicksort(a, last + 1, right);
        }
        public Sort(int T)
        {
            a = new int[T];
            this.t = T;
        }

    }

}
