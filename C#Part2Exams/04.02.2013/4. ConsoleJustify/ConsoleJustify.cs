using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConsoleJustify
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int numberOfSymbols = int.Parse(Console.ReadLine());

        StringBuilder text = new StringBuilder();

        for (int i = 0; i < numberOfLines; i++)
        {
            text.Append(Console.ReadLine());
            text.Append(" ");
        }
        char[] separators = new char[] { ' ' };
        string[] splittedText = text.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        int spaceCounter = 2;

        StringBuilder outputText = new StringBuilder();

        for (int i = 0; i < splittedText.Length; i++)
        {
            if (((outputText.ToString() + splittedText[i]).Length <= numberOfSymbols))
            {
                outputText.Append(splittedText[i]);
                if ((outputText.ToString() + " ").Length < numberOfSymbols)
                {
                        outputText.Append(" ");
                }
            }
            else
            {
                if (outputText[outputText.Length - 1] == ' ')
                {
                    outputText.Remove(outputText.Length - 1, 1);
                }
                int index = outputText.ToString().IndexOf(' ', 0);

                if (index == -1)
                {
                    Console.WriteLine(outputText.ToString().TrimEnd(separators));
                    outputText.Clear();
                }

                int firstIndex = index;
                while (index != -1)
                {
                    if (outputText.Length == numberOfSymbols)
                    {
                        Console.WriteLine(outputText.ToString().TrimEnd(separators));
                        outputText.Clear();
                        spaceCounter = 2;
                        break;
                    }
                    else
                    {
                        outputText.Insert(index, ' ');
                        index = outputText.ToString().IndexOf(' ', index + spaceCounter);                     
                    }
                    if (index == -1)
                    {
                        spaceCounter++;
                        index = firstIndex;
                    }
                }
                outputText.Append(splittedText[i] + " ");
            }
        }
        if (outputText[outputText.Length - 1] == ' ')
        {
            outputText.Remove(outputText.Length - 1, 1);
        }

        int index1 = outputText.ToString().IndexOf(' ', 0);
        int firstIndex1 = index1;
        spaceCounter = 2;
        if (index1 == -1)
        {
            Console.WriteLine(outputText.ToString().TrimEnd(separators));
            outputText.Clear();
        }

        while (index1 != -1)
        {
            if (outputText.Length == numberOfSymbols)
            {
                Console.WriteLine(outputText.ToString().TrimEnd(separators));
                outputText.Clear();
                spaceCounter = 2;
                break;
            }
            else
            {
                outputText.Insert(index1, ' ');
                index1 = outputText.ToString().IndexOf(' ', index1 + spaceCounter);
                
            }
            if (index1 == -1)
            {
                index1 = firstIndex1;
                spaceCounter++;
            }
        }
    }
}

