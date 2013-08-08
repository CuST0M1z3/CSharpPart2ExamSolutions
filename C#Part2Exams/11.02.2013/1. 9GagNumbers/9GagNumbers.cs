using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] symbols = new string[] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        StringBuilder exact = new StringBuilder();
        List<ulong> number = new List<ulong>();

        for (int i = 0; i < input.Length; i++)
        {
            exact.Append(input[i]);

            switch (exact.ToString())
            {
                case "-!":
                    number.Add(0);
                    exact.Clear();
                    break;
                case "**":
                    number.Add(1);
                    exact.Clear();
                    break;
                case "!!!":
                    number.Add(2);
                    exact.Clear();
                    break;
                case "&&":
                    number.Add(3);
                    exact.Clear();
                    break;
                case "&-":
                    number.Add(4);
                    exact.Clear();
                    break;
                case "!-":
                    number.Add(5);
                    exact.Clear();
                    break;
                case "*!!!":
                    number.Add(6);
                    exact.Clear();
                    break;
                case "&*!":
                    number.Add(7);
                    exact.Clear();
                    break;
                case "!!**!-":
                    number.Add(8);
                    exact.Clear();
                    break;
            }
        }

        ulong[] arrayToReverse = number.ToArray();
        Array.Reverse(arrayToReverse);

        ulong result = 0;
        ulong power = 0;

        for (int i = 0; i < arrayToReverse.Length; i++)
        {
            power = (ulong)BigInteger.Pow(9, i);
            result += (arrayToReverse[i] * power);
        }

        Console.WriteLine(result);
        
    }
}

