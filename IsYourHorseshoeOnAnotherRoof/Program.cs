using System;

namespace IsYourHorseshoeOnAnotherRoof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int counter = 0;
            Random r = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                for(int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j]) {
                        counter++;
                        input[j] = (r.Next(10, 1000)).ToString();
                    } 
                }
            }

            Console.WriteLine(counter);
        }
    }
}
