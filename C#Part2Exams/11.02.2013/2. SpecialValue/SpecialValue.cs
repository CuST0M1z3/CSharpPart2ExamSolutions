using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpecialValue
{
    static void Main()
    {
        int numberOfRows = int.Parse(Console.ReadLine());

        int[][] matrix = new int[numberOfRows][];

        char[] separators = new char[] { ' ', ',' };

        for (int i = 0; i < numberOfRows; i++)
        {
            string text = Console.ReadLine();
            string[] columns = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            matrix[i] = new int[columns.Length];

            for (int j = 0; j < columns.Length; j++)
            {
                matrix[i][j] = int.Parse(columns[j]);
            }
        }

        SpecValue(matrix, numberOfRows);
    }

    static void SpecValue(int[][] matrix, int numberOfRows)
    {
        int path = 1;
        int specialValue = 0;
        int currentIndex = 0;
        int rowCounter = 0;
        int maxSpecialValue = int.MinValue;

        bool[][] visited = new bool[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            visited[i] = new bool[matrix[i].Length]; 
        }

        for (int i = 0; i < matrix[0].Length; i++)
        {

            for (int k = 0; k < visited.Length; k++)
            {
                visited[k] = new bool[matrix[k].Length];
            }

            specialValue = 0;
            path = 1;
            rowCounter = 0;
            currentIndex = matrix[0][i]; 
            if (matrix[0][i] < 0 && visited[0][i] == false)
            {
                specialValue = path + Math.Abs(matrix[0][i]);
                visited[0][i] = true;
            }
            // else if (visited[0][i] == true)
            // {
            //    continue;
            // }
            else
            {                                          
                while (true)
                {
                    rowCounter++;
                    path++;
                    if (rowCounter >= numberOfRows)
                    {
                        rowCounter = 0;
                    }
                    if (matrix[rowCounter][currentIndex] < 0 && visited[rowCounter][currentIndex] == false)
                    {
                        specialValue = path + Math.Abs(matrix[rowCounter][currentIndex]);
                        visited[rowCounter][currentIndex] = true;
                        break;
                    }
                    else if (visited[rowCounter][currentIndex] == true)
                    {
                        specialValue = 0;
                        break;
                    }
                    else
                    {
                        visited[rowCounter][currentIndex] = true;
                        currentIndex = matrix[rowCounter][currentIndex];
                    }

                }               
            }
            if (specialValue > maxSpecialValue)
            {
                maxSpecialValue = specialValue;
            }
        }
        Console.WriteLine(maxSpecialValue);
    }
}

