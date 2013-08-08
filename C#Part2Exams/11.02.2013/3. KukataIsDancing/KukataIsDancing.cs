using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KukataIsDancing
{
    static void Main()
    {
        string[,] cube = new string[3, 3];

        cube[0, 0] = "RED"; cube[0, 2] = "RED"; cube[2, 0] = "RED"; cube[2, 2] = "RED";
        cube[0, 1] = "BLUE"; cube[1, 0] = "BLUE"; cube[1, 2] = "BLUE"; cube[2, 1] = "BLUE";
        cube[1, 1] = "GREEN";

        int number = int.Parse(Console.ReadLine());
        int currentIndexX = 1;
        int currentIndexY = 1;
        int currentDirection = 0;

        for (int i = 0; i < number; i++)
        {
            string text = Console.ReadLine();

            currentIndexX = 1;
            currentIndexY = 1;

            for (int j = 0; j < text.Length; j++)
            {
                switch (text[j])
                {
                    case 'L':
                        currentDirection += 1;
                        if (currentDirection > 3)
                        {
                            currentDirection = 0;
                        }
                        break;
                    case 'R':
                        currentDirection -= 1;
                        if (currentDirection < -3)
                        {
                            currentDirection = 0;
                        }
                        break;
                    case 'W':
                        if (currentDirection == 0)
                        {
                            currentIndexX += 1;
                        }
                        else if (currentDirection == 1 || currentDirection == -3)
                        {
                            currentIndexY += 1;
                        }
                        else if (currentDirection == 2 || currentDirection == -2)
                        {
                            currentIndexX -= 1;
                        }
                        else if (currentDirection == 3 || currentDirection == -1)
                        {
                            currentIndexY -= 1;
                        }
                        break;
                }
                if (currentIndexX > 2)
                {
                    currentIndexX = 0;
                }
                else if (currentIndexX < 0)
                {
                    currentIndexX = 2;
                }
                if (currentIndexY > 2)
                {
                    currentIndexY = 0;
                }
                else if (currentIndexY < 0)
                {
                    currentIndexY = 2;
                }
            }
            Console.WriteLine(cube[currentIndexX, currentIndexY]);       
        }
    }
}

