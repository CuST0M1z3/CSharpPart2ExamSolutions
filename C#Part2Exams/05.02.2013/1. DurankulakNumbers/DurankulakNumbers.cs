using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DurankulakNumbers
{
    static void Main()
    {
        string[] letters = new string[168];

        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[i - 'A'] = i.ToString();
        }

        int count = 26;

        for (char i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                if (count < 168)
                {
                    letters[count] = i.ToString() + j.ToString();
                    count++;
                }
             }
        }

        int power = 0;
        ulong number = 0;
        string input = Console.ReadLine();

        StringBuilder letter = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (!(char.IsUpper(input[i])))
            {
                letter.Append(input[i]);
            }
            else if (i > 0 && char.IsUpper(input[i]) && !((char.IsUpper(input[i - 1]))))
            {
                letter.Append(input[i] + " ");
            }
            else
            {
                letter.Append(input[i] + " ");
            }
        }

        char[] separators = new char[] { ' ' };

        if (letter.Length > 0)
        {
            string[] inputs = letter.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            power = inputs.Length - 1;
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    int result = string.Compare(inputs[i], letters[j], false);
                    if (result == 0)
                    {
                        number += ((ulong)j * (ulong)Math.Pow(168, power));
                        power--;
                        break;
                    }
                }
            }
        }       
        Console.WriteLine(number);
    }
}

