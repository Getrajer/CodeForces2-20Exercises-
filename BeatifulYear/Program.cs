using System;

namespace BeatifulYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();

            int year_int = Convert.ToInt32(year);


            bool isDiffrent = true;


            while (isDiffrent)
            {
                year_int++;

                string new_year = year_int.ToString();
                bool ifFine = true;

                for(int i = 0; i < new_year.Length - 1; i++)
                {
                    for(int j = i + 1; j < new_year.Length; j++)
                    {
                        if(new_year[i] == new_year[j])
                        {
                            ifFine = false;
                        }
                    }
                }

                if (ifFine) isDiffrent = !isDiffrent;
            }

            Console.WriteLine(year_int.ToString());

        }
    }
}
