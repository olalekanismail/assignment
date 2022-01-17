using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1

            int[] a = { 1, 2, 3, 5, 6 };
            int miss = getMissingNo(a, 5);
            Console.Write(miss);


        }
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }

    }   
    
}
