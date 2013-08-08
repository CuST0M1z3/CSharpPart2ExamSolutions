using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CSharpBrackets
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string indentation = Console.ReadLine();

        string text = "";

        StringBuilder outputText = new StringBuilder();

        int spaceCounter = 0;
        int bracketCounter = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            text = Console.ReadLine().Trim();

            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] != '{' && text[j] != '}')
                {
                    if (text[j] == ' ' && (text[j - 1] != '{' && text[j - 1] != '}' && outputText[outputText.Length - 1] != indentation[0]))
                    {
                        spaceCounter++;
                        if (spaceCounter < 2)
                        {
                            outputText.Append(' ');
                        }
                    }
                    else
                    {
                        if (outputText.Length > 1 && (outputText[outputText.Length - 2] == '{' || outputText[outputText.Length - 2] == '}'))
                        {
                            for (int k = 0; k < bracketCounter; k++)
                            {
                                outputText.Append(indentation);
                            }
                        }
                        if (outputText.Length > 0 && outputText[outputText.Length - 1] == '\n')
                        {
                            for (int k = 0; k < bracketCounter; k++)
                            {
                                outputText.Append(indentation);
                            }
                        }
                        if (text[j] != ' ')
                        {
                            outputText.Append(text[j]);
                        }                        
                        spaceCounter = 0;
                    }
                }
                else if (text[j] == '{')
                {
                    if (outputText.Length > 0 && outputText[outputText.Length - 1] != '\n')
                    {
                        outputText.Append("\n");
                    }
                    for (int k = 0; k < bracketCounter; k++)
                    {
                        outputText.Append(indentation);
                    }
                    bracketCounter++;
                    outputText.Append('{');
                    outputText.Append("\n");
                }
                else if (text[j] == '}')
                {
                    if (outputText[outputText.Length - 1] != '\n')
                    {
                        outputText.Append("\n");
                    }
                    bracketCounter--;
                    for (int k = 0; k < bracketCounter; k++)
                    {
                        outputText.Append(indentation);
                    }                   
                    outputText.Append('}');
                    outputText.Append("\n");
                }

            }
            if (outputText[outputText.Length - 1] != '\n' && outputText[outputText.Length - 1] != '{' && outputText[outputText.Length - 1] != '}')
            {
                outputText.Append("\n"); 
            }
        }


            
        Console.WriteLine(outputText.ToString());
    }
}

