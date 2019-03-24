using System;

namespace zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Unesite broj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j < n; j++) Console.Write(" ");
                for (int j = 0; j < 2 * i - 1; j++) Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
