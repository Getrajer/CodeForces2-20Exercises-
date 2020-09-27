using System;

namespace UltraFastMatchematician
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string output = "";

            for(int i = 0; i < input1.Length; i++)
            {
                if(input1[i] == '1' && input2[i] == '1')
                {
                    output += '0';
                }
                else if (input1[i] == '1' && input2[i] == '0')
                {
                    output += '1';
                }
                else if(input1[i] == '0' && input2[i] == '1')
                {
                    output += '1';
                }
                else if (input1[i] == '0' && input2[i] == '0')
                {
                    output += '0';
                }
            }

            Console.WriteLine(output);
        }
    }
}
