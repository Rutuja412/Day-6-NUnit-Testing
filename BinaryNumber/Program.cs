using System;
using System.Transactions;

namespace BinaryNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.WriteLine("Enter number ");
            n=int.Parse(Console.ReadLine());
            for(i=0;n>0;i++) 
            {
                a[i] = n % 2;
                n= n / 2;
            }
            Console.WriteLine("Binary Conversion= ");
            for(i=i-1;i>=0;i--) 
            {
                Console.Write(a[i]);
            }
        }
    }
}
