using System;
using System.Text;

namespace SortComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int g;
            Console.OutputEncoding = Encoding.UTF8;
            const int t = 40000;
            Sort s1 = new Sort(t);
            Sort s2 = new Sort(t);
            Sort s3 = new Sort(t);
            for (int i = 0; i < t; i++)
            {
                System.Random r = new System.Random(i);
                g = (r.Next(t)+1);
                s1.a[i] = g;
                s2.a[i] = g;
                s3.a[i] = g;
            }
            s1.sortstart();
            s1.bubblesort();
            s1.sortquit("バブルソート");
            s2.sortstart();
            s2.Quicksort(s2.a,0,t-1);
            s2.sortquit("クイックソート");
            s3.sortstart();
            s3.mergeSort(s3.a);
            s3.sortquit("マージソート");
            
            string j = Console.ReadLine();
            
        }
    }
}