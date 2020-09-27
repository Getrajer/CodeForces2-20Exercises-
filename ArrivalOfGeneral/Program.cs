using System;

namespace ArrivalOfGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] soldiers = Console.ReadLine().Split();

            int[] heights = new int[n];

            for(int i = 0; i < soldiers.Length; i++)
            {
                heights[i] = Convert.ToInt32(soldiers[i]);
            }

            soldiers = new string[0];

            int maxIndex = 0;
            int max = 0;
            int minIndex = 0;
            int min = 0;

            for(int i = 0; i < heights.Length; i++)
            {
                if(i == 0)
                {
                    max = heights[i];
                    min = heights[i];
                    maxIndex = i;
                    minIndex = i;
                }
                else
                {
                    if(heights[i] > max)
                    {
                        max = heights[i];
                        maxIndex = i;
                    }

                    if(heights[i] <= min)
                    {
                        min = heights[i];
                        minIndex = i;
                    }
                }
            }

            int moves = 0;

            if(maxIndex > minIndex)
            {
                moves += maxIndex;
                moves += n - minIndex - 2;
            }
            else
            {
                moves += maxIndex;
                moves += n - minIndex - 1;
            }

            Console.WriteLine(moves);
        }
    }
}
