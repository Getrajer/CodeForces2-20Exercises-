using System;
using System.Collections.Generic;

namespace IWannaBeTheGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] player1 = Console.ReadLine().Split();
            string[] player2 = Console.ReadLine().Split();

            int p1games = Convert.ToInt32(player1[0]);
            int p2games = Convert.ToInt32(player1[0]);

            List<int> p1Lost = new List<int>();
            List<int> p2Lost = new List<int>();


            int c = 0;
            for(int i = 1; i <= n; i++)
            {
                bool lost = true;
                for(int j = 1; j < player1.Length; j++)
                {
                    if(i == Convert.ToInt32(player1[j]))
                    {
                        lost = false;
                        break;
                    }
                }

                if (lost) p1Lost.Add(i);

                lost = true;
                for (int j = 1; j < player2.Length; j++)
                {
                    if (i == Convert.ToInt32(player2[j]))
                    {
                        lost = false;
                        break;
                    }
                }

                if (lost) p2Lost.Add(i);
            }

            bool won = true;

            if(p1Lost.Count <= p2Lost.Count)
            {
                for(int i = 0; i < p1Lost.Count; i++)
                {
                    for(int j = 0; j < p2Lost.Count; j++)
                    {
                        if(p1Lost[i] == p2Lost[j])
                        {
                            won = false;
                        }
                    }
                }

            }
            else
            {
                for (int i = 0; i < p2Lost.Count; i++)
                {
                    for (int j = 0; j < p1Lost.Count; j++)
                    {
                        if (p2Lost[i] == p1Lost[j])
                        {
                            won = false;
                        }
                    }
                }
            }


            if (won)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
