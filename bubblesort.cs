using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace SortComparison
{
    class bubblesort
    {
        public const int t = 40000;
        public int[] a = new int[t];
        Stopwatch sw = new Stopwatch();
        
        public void sort()
        {
            sw.Start();
            int k;
            for(int i = 0; i <  t - 1;++i)
            {
                for(int j = t -1;i < j; --j)
                {
                    if (a[i] > a[j])
                    {
                        k = a[i]; a[i] = a[j]; a[j] = k; 
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("バブルソートで並べ替えをした配列の百個目までを表示します。");
            for(int i = 0; i < 100; ++i)
            {
                Console.Write("{0}"+" ", a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("実行時間は{0}ミリ秒です。", sw.ElapsedMilliseconds);

        }
    }
}
