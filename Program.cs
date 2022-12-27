using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number of the range:");
            int start = Convert.ToInt32(Console.ReadLine());    
            Console.Write("Enter the end number of the range:");
            int end =Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime numbers between {0} and {1} are :",start,end);

            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.Write("\n" +i);
                }
            }
            Console.ReadKey(); 
        }

        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
            
        }
    }
}