using System;

namespace AmusingJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string pile = Console.ReadLine();

            int c = 0;
            bool notFound = false;
            for(int i = 0; i < input1.Length; i++)
            {
                if(notFound == true)
                {
                    break;
                }

                if(pile.Length > 0)
                {
                    for (int j = 0; j < pile.Length; j++)
                    {
                        if (input1[i] != pile[j])
                        {
                            notFound = true;
                        }
                        else
                        {
                            notFound = false;
                            pile = pile.Remove(j, 1);
                            break;
                        }
                    }
                }
                else
                {
                    notFound = true;
                }

                
            }

            for (int i = 0; i < input2.Length; i++)
            {
                if (notFound == true)
                {
                    break;
                }

                if (pile.Length > 0)
                {
                    for (int j = 0; j < pile.Length; j++)
                    {
                        if (input2[i] != pile[j])
                        {
                            notFound = true;
                        }
                        else
                        {
                            notFound = false;
                            pile = pile.Remove(j, 1);
                            break;
                        }
                    }
                }
                else
                {
                    notFound = true;
                }


            }

            if(pile.Length == 0 && notFound == false)
            {
                Console.WriteLine("YES");
            }
            else if(pile.Length > 0)
            {
                Console.WriteLine("NO");
            }

        }
    }
}
