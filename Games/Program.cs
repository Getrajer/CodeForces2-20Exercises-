using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] teams = new int[n,2];

            for(int i = 0; i < n; i++)
            {
                string[] txt = Console.ReadLine().Split();

                teams[i, 0] = Convert.ToInt32(txt[0]);
                teams[i, 1] = Convert.ToInt32(txt[1]);
            }

            int games = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(teams[i,0] == teams[j, 1])
                    {
                        games++;
                    }

                    if(teams[i,1] == teams[j, 0])
                    {
                        games++;
                    }
                }
            }

            Console.WriteLine(games);

        }
    }
}
