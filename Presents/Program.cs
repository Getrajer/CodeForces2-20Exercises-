using System;

namespace Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string numbers = Console.ReadLine();

            int[] guests = new int[n];

            string txt = "";
            int c = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != ' ')
                {
                    txt += numbers[i];
                }
                else
                {
                    guests[c] = Convert.ToInt32(txt);
                    txt = "";
                    c++;
                }
            }

            //last guest
            guests[c] = Convert.ToInt32(txt);

            int[] exchange = new int[n];


            for(int i = 0; i < n; i++)
            {
                exchange[guests[i] - 1] = i + 1;
            }

            for(int i = 0; i < n; i++)
            {
                if(i != n - 1)
                {
                    Console.Write(exchange[i] + " ");
                }
                else
                {
                    Console.Write(exchange[i]);
                }
            }

        }
    }
}
