using System;

namespace GeorgeAndAccomodation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRooms = Convert.ToInt32(Console.ReadLine());
            int freeRooms = 0;

            for(int i = 0; i < numberOfRooms; i++)
            {
                string input = Console.ReadLine();
                string txt = "";
                int c = 0;

                int people = 0;
                int capacity = 0;

                for(int j = 0; j < input.Length; j++)
                {
                    if(input[j] != ' ')
                    {
                        txt += input[j];
                    }
                    else
                    {
                        if(c == 0)
                        {
                            people = Convert.ToInt32(txt);
                            c++;
                            txt = "";
                        }
                    }
                }

                capacity = Convert.ToInt32(txt);

                if(capacity - people >= 2)
                {
                    freeRooms++;
                }

            }

            Console.WriteLine(freeRooms);

        }
    }
}
