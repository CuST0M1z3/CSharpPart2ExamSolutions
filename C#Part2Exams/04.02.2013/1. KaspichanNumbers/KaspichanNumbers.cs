using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspichanNumbers
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        string[] letters = new string[256];

        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[i - 'A'] = i.ToString();
        }

        int count = 26;

        for (char i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                if (count < 256)
                {
                    letters[count] = (i.ToString() + j.ToString());
                    count++;
                }
            }
        }
        if (number == 0)
        {
            Console.WriteLine('A');
        }
        else
        {
            findLetters(number, letters);
        }       
    }

    static void findLetters(ulong number, string[] letters)
    {
        List<ulong> symbols = new List<ulong>();

        ulong remainder = 0;

        while (number > 0)
        {
            remainder = number % 256;
            number = number / 256;
            symbols.Add(remainder);
        }

        StringBuilder result = new StringBuilder();

        for (int i = symbols.Count - 1; i >= 0; i--)
        {
            result.Append(letters[symbols[i]]);
        }

        Console.WriteLine(result.ToString());
    }
}

