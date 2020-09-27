using System;

namespace Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if(n == 1)
            {
                Console.WriteLine("I hate it");
            }

            if (n == 2)
            {
                Console.WriteLine("I hate that I love it");
            }

            if(n > 2)
            {
                bool hate = false;

                for(int i = 0; i < n; i++)
                {
                    if(i != n - 1)
                    {
                        if (!hate)
                        {
                            Console.Write("I hate that ");
                            hate = !hate;
                        }
                        else
                        {
                            Console.Write("I love that ");
                            hate = !hate;
                        }
                    }
                    else
                    {
                        if (!hate)
                        {
                            Console.Write("I hate it");
                        }
                        else
                        {
                            Console.Write("I love it");
                        }
                    }
                }
            }

        }
    }
}
