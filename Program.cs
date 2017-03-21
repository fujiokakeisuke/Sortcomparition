using System;
using System.Text;

namespace SortComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 40000;
            int g;
            Console.OutputEncoding = Encoding.UTF8;
            bubblesort b = new bubblesort();
            quicksort q = new quicksort();
            mergesort m = new mergesort();
            for (int i = 0; i < t; i++)
            {
                System.Random r = new System.Random(i);
                g = (r.Next(t)+1);
                b.a[i] = g;
                q.a[i] = g;
                m.a[i] = g;
            }
            b.sort();
            q.sort();
            m.sort();
            string j = Console.ReadLine();
            
        }
    }
}