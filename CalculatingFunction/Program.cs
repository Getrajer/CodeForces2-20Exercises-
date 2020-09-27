using System;

namespace CalculatingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt32(Console.ReadLine());

            long result = 0;

            if(n%2 == 0)
            {
                result = n / 2;
            }
            else
            {
                result = ((n + 1) / 2) * (-1);
            }

            Console.WriteLine(result);
        }
    }
}
