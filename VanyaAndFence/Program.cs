using System;

namespace VanyaAndFence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int n = 0;
            int h = 0;


            string txt = "";
            int c = 0;
            for(int i = 0; i < input1.Length; i++)
            {
                if(input1[i] != ' ')
                {
                    txt += input1[i];
                }
                else
                {
                    if(c == 0)
                    {
                        n = Convert.ToInt32(txt);
                        txt = "";
                        c++;
                    }
                }
            }
            h = Convert.ToInt32(txt);
            txt = "";
            c = 0;

            int[] people = new int[n];

            for(int i = 0; i < input2.Length; i++)
            {
                if (input2[i] != ' ')
                {
                    txt += input2[i];
                }
                else
                {
                    people[c] = Convert.ToInt32(txt);
                    txt = "";
                    c++;
                }
            }
            //Last person
            people[c] = Convert.ToInt32(txt);

            int width = n;

            for(int i = 0; i < people.Length; i++)
            {
                if(people[i] > h)
                {
                    width++;
                }
            }

            Console.WriteLine(width);

        }
    }
}
