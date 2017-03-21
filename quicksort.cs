using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace SortComparison
{
    class quicksort
    {
        public const int t = 40000;
        public int[] a = new int[t];
        Stopwatch sw = new Stopwatch();

        public void sort()
        {
            sw.Start();
            Quicksort( a,0, t - 1);
            
            sw.Stop();
            Console.WriteLine("クイックソートで並べ替えをした配列の百個目までを表示します。");
            for (int i = 0; i < 100; ++i)
            {
                Console.Write("{0}" + " ", a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("実行時間は{0}ミリ秒です。", sw.ElapsedMilliseconds);

        }
        public static void Quicksort(int[] a,int left,int right)
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

    }

}
