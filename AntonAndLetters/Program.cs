using System;

namespace AntonAndLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string distinct = "";
            int count = 0;


            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] != '{' && input[i] != '}' && input[i] != ',' && input[i] != ' ')
                {
                    bool isThere = false;

                    for(int j = 0; j < distinct.Length; j++)
                    {
                        if(input[i] == distinct[j])
                        {
                            isThere = true;
                        }
                    }

                    if(isThere == false)
                    {
                        distinct += input[i];
                    }
                }
            }

            Console.WriteLine(distinct.Length);

        }
    }
}
