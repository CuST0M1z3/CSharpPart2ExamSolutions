using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Laser
{
    static void Main()
    {
        string[] cubeSize = Console.ReadLine().Split();

        int cubeWidth = int.Parse(cubeSize[0]);
        int cubeHeight = int.Parse(cubeSize[1]);
        int cubeDepth = int.Parse(cubeSize[2]);

        bool[, ,] visited = new bool[cubeWidth, cubeHeight, cubeDepth];

        string[] startCoords = Console.ReadLine().Split();

        int posW = int.Parse(startCoords[0]);
        int posH = int.Parse(startCoords[1]);
        int posD = int.Parse(startCoords[2]);

        string[] directionComponents = Console.ReadLine().Split();

        int dirW = int.Parse(directionComponents[0]);
        int dirH = int.Parse(directionComponents[1]);
        int dirD = int.Parse(directionComponents[2]);

        while (true)
        {
            visited[posW - 1, posH - 1, posD - 1] = true;

            posW = posW + dirW;
            posH = posH + dirH;
            posD = posD + dirD;
            
            if (visited[posW - 1, posH - 1, posD - 1] == true)
            {
                Console.WriteLine("{0} {1} {2}", posW - dirW, posH - dirH, posD - dirD);
                break;
            }            
            else
            {
                if (posW == 1 || posW == cubeWidth)
                {
                    dirW = dirW * (-1);
                }
                else if (posH == 1 || posH == cubeHeight)
                {
                    dirH = dirH * (-1);
                }
                else if (posD == 1 || posD == cubeDepth)
                {
                    dirD = dirD * (-1);
                }
            }           
        }
    }
}