using System;

namespace DivisibilityProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] moves = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int n1 = Convert.ToInt32(input[0]);
                int n2 = Convert.ToInt32(input[1]);

                int m = 0;

                while( n1 % n2 != 0)
                {
                    m++;
                    n1++;
                }

                moves[i] = m;
            }

            for(int i = 0; i < moves.Length; i++)
            {
                Console.WriteLine(moves[i]);
            }
        }
    }
}
