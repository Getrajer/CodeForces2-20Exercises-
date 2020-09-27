using System;

namespace InSerchOfAnEasyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string answers = Console.ReadLine();

            bool ishard = false;

            for(int i = 0; i < answers.Length; i++)
            {
                if(answers[i] != ' ')
                {
                    if(answers[i] == '1')
                    {
                        ishard = true;
                    }
                }
            }

            if (ishard)
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }

        }
    }
}
