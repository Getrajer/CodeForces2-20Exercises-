using System;

namespace Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string prev = "";
            string next = "";
            int groups = 0;

            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    prev = Console.ReadLine();
                    groups++;
                }

                next = Console.ReadLine();

                if(prev == "10")
                {
                    if(next == "01")
                    {
                        groups++;
                    }
                }

                if(prev == "01")
                {
                    if(next == "10")
                    {
                        groups++;
                    }
                }

                prev = next;

            }

            Console.WriteLine(groups);

        }
    }
}
