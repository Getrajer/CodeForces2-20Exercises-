using System;
using System.Collections.Generic;

namespace InsomniaCureWrongApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int ogk = k;
            int ogl = l;
            int ogm = m;
            int ogn = n;


            int[] dragons = new int[d];

            for(int i = 0; i < dragons.Length; i++)
            {
                dragons[i] = i + 1;
            }

            List<int> hurt_dragons = new List<int>();

            for(int i = 0; i < dragons.Length; i++)
            {
                if(i == k - 1)
                {
                    bool isHurt = false;
                    for(int j = 0; j < hurt_dragons.Count; j++)
                    {
                        if (hurt_dragons[j] == dragons[i])
                        {
                            isHurt = true;
                        }
                    }
                    if (!isHurt)
                    {
                        hurt_dragons.Add(dragons[i]);
                    }

                    k += ogk;
                }

                if (i == l - 1)
                {
                    bool isHurt = false;
                    for (int j = 0; j < hurt_dragons.Count; j++)
                    {
                        if (hurt_dragons[j] == dragons[i])
                        {
                            isHurt = true;
                        }
                    }
                    if (!isHurt)
                    {
                        hurt_dragons.Add(dragons[i]);
                    }

                    l += ogl;
                }

                if (i == m - 1)
                {
                    bool isHurt = false;
                    for (int j = 0; j < hurt_dragons.Count; j++)
                    {
                        if (hurt_dragons[j] == dragons[i])
                        {
                            isHurt = true;
                        }
                    }
                    if (!isHurt)
                    {
                        hurt_dragons.Add(dragons[i]);
                    }

                    m += ogm;
                }

                if (i == n - 1)
                {
                    bool isHurt = false;
                    for (int j = 0; j < hurt_dragons.Count; j++)
                    {
                        if (hurt_dragons[j] == dragons[i])
                        {
                            isHurt = true;
                        }
                    }
                    if (!isHurt)
                    {
                        hurt_dragons.Add(dragons[i]);
                    }

                    n += ogn;
                }
            }

            Console.WriteLine(hurt_dragons.Count);

        }
    }
}
