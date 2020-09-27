using System;

namespace AntonAndPolyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for(int i = 0; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "Tetrahedron") sum += 4;
                if (input == "Cube") sum += 6;
                if (input == "Octahedron") sum += 8;
                if (input == "Dodecahedron") sum += 12;
                if (input == "Icosahedron") sum += 20;
            }

            Console.WriteLine(sum);
        }
    }
}
