using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
    static void Main()
    {
        string val = Console.ReadLine();
        char[] sepatarots = new char[] { ' ', ',' };
        string[] splittedValley = val.Split(sepatarots, StringSplitOptions.RemoveEmptyEntries);
        int[] valley = new int[splittedValley.Length];

        for (int i = 0; i < valley.Length; i++)
        {
            valley[i] = int.Parse(splittedValley[i]);
        }

        int maxCoins = int.MinValue;
        int patterns = int.Parse(Console.ReadLine());

        for (int i = 0; i < patterns; i++)
        {
            string pat = Console.ReadLine();
            string[] patCheck = pat.Split(sepatarots, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[patCheck.Length];

            for (int j = 0; j < pattern.Length; j++)
            {
                pattern[j] = int.Parse(patCheck[j]);
            }

            bool[] visited = new bool[valley.Length];

            int currentIndex = 0;
            int path = 0;
            int currentCoins = 0;
            int nextIndex = 0;
            int patternCounter = 0;

            while (true)
            {
                if (currentIndex >= 0 && currentIndex < valley.Length && visited[currentIndex] == false)
                {
                    currentCoins += valley[currentIndex];
                    visited[currentIndex] = true;
                    path = pattern[patternCounter];
                    nextIndex = currentIndex + path;
                    currentIndex = nextIndex;
                    patternCounter++;
                }
                else
                {
                    break;
                }
                if (patternCounter >= pattern.Length)
                {
                    patternCounter = 0;
                }
                              
            }
            if (currentCoins > maxCoins)
            {
                maxCoins = currentCoins;
            }
        }
            
        Console.WriteLine(maxCoins);
    }
}

