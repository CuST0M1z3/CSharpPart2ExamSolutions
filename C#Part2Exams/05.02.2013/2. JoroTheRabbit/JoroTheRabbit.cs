using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JoroTheRabbit
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] separators = new char[] { ' ', ',' };

        string[] splittedInput = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        int[] terrain = new int[splittedInput.Length];

        for (int i = 0; i < terrain.Length; i++)
        {
            terrain[i] = int.Parse(splittedInput[i]);
        }

        int bestPath = 0;

        for (int startIndex = 0; startIndex < terrain.Length; startIndex++)
        {
            for (int step = 1; step < terrain.Length; step++)
            {
                int index = startIndex;
                int currentPath = 1;
                int next = (index + step);
                if (next >= terrain.Length)
                {
                    next = next - terrain.Length;
                }

                while (terrain[index] < terrain[next])
                {
                    currentPath++;
                    index = next;

                    next = (index + step) % terrain.Length;
                }

                if (currentPath > bestPath)
                {
                    bestPath = currentPath;
                }
            }
        }

        Console.WriteLine(bestPath);

    }
}


