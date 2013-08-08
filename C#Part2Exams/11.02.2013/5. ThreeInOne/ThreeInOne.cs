using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThreeInOne
{
    static void Main()
    {
        Task1Blackjack();
        Task2Bites();
        Task3Money();
    }

    static void Task1Blackjack()
    {
        string input = Console.ReadLine();

        string[] splittedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] scores = new int[splittedInput.Length];

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = int.Parse(splittedInput[i]);
        }

        int maxScore = 0;
        int winnerCounter = 1;
        int winnerKey = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] <= 21)
            {
                if (scores[i] == maxScore)
                {
                    winnerCounter++;
                }
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    winnerKey = i;
                    winnerCounter = 1;
                }
            }
        }
        if (winnerCounter > 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(winnerKey);
        }
    }

    static void Task2Bites()
    {
        string input = Console.ReadLine();

        string[] splittedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] bites = new int[splittedInput.Length];

        for (int i = 0; i < bites.Length; i++)
        {
            bites[i] = int.Parse(splittedInput[i]);
        }

        int numberOfFriends = int.Parse(Console.ReadLine());
        int myBites = 0;

        Array.Sort(bites);

        for (int i = bites.Length - 1; i >= 0; i -= numberOfFriends + 1)
        {
            myBites += bites[i];
        }
        Console.WriteLine(myBites);
    }

    static void Task3Money()
    {
        string input = Console.ReadLine();

        string[] splittedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] haveMoney = new int[3];
        int[] requiredMoney = new int[3];

        int counter = 0;

        for (int i = 0; i < 6; i++)
        {
            if (i < 3)
            {
                haveMoney[i] = int.Parse(splittedInput[i]);
            }
            else
            {
                requiredMoney[counter] = int.Parse(splittedInput[i]);
                counter++;
            }
        }

        int goldCoins = haveMoney[0];
        int silverCoins = haveMoney[1];
        int bronzeCoins = haveMoney[2];

        int requiredGoldCoins = requiredMoney[0];
        int requiredSilverCoins = requiredMoney[1];
        int requiredBronzeCoins = requiredMoney[2];

        int exchangeOperations = 0;
        while (requiredGoldCoins > goldCoins)
        {
            --requiredGoldCoins;
            requiredSilverCoins += 11;
            exchangeOperations++;
        }

        while (requiredSilverCoins > silverCoins)
        {
            if (goldCoins > requiredGoldCoins)
            {
                --goldCoins;
                silverCoins += 9;
                exchangeOperations++;
            }
            else
            {
                --requiredSilverCoins;
                requiredBronzeCoins += 11;
                exchangeOperations++;
            }
        }

        while (requiredBronzeCoins > bronzeCoins)
        {
            if (silverCoins > requiredSilverCoins)
            {
                --silverCoins;
                bronzeCoins += 9;
                exchangeOperations++;
            }
            else if (goldCoins > requiredGoldCoins)
            {
                --goldCoins;
                silverCoins += 9;
                exchangeOperations++;
            }
            else
            {
                Console.WriteLine(-1);
                return;
            }
        }

        Console.WriteLine(exchangeOperations);
        return;
    }
}

