using System;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string numbers = Console.ReadLine();

            string txt = "";

            double sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != ' ')
                {
                    txt += numbers[i];
                }
                else
                {
                    sum += Convert.ToInt32(txt);
                    txt = "";
                }
            }

            //last
            sum += Convert.ToInt32(txt);


            Console.WriteLine(sum / n);
        }
    }
}
