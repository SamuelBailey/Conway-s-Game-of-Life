using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    class LifeGrid
    {
        public bool[,] grid;

        /// <summary>
        /// Instantiates to all cells empty in a bool array with size x,y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public LifeGrid(int x, int y)
        {
            grid = new bool[x, y];
        }

        /// <summary>
        /// Creates a LifeGrid and sets the cells according to the boolArray
        /// </summary>
        /// <param name="boolArray">Array containing the alive states of all the cells</param>
        public LifeGrid(bool[,] boolArray)
        {
            grid = new bool[boolArray.GetLength(0), boolArray.GetLength(1)];
            for (int i = 0; i < boolArray.GetLength(0); i++)
            {
                for (int j = 0; j < boolArray.GetLength(1); j++)
                {
                    grid[j, i] = boolArray[j, i];
                }
            }
        }

        public bool[,] CalculateNextFrame()
        {
            bool[,] tempBoolArray = new bool[grid.GetLength(0), grid.GetLength(1)];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    tempBoolArray[j, i] = CalculateCell(j, i, grid);
                }
            }
            return tempBoolArray;
        }

        bool CalculateCell(int xPos, int yPos, bool[,] boolArray)
        {
            int cellCount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (j != 0 || i != 0)
                    {
                        int xOffset = (xPos + j) % boolArray.GetLength(0);
                        int yOffset = (yPos + i) % boolArray.GetLength(1);

                        if (xOffset < 0)
                            xOffset += boolArray.GetLength(0);
                        if (yOffset < 0)
                            yOffset += boolArray.GetLength(1);

                        if (boolArray[xOffset, yOffset])
                        {
                            cellCount++;
                        }
                    }
                }
            }
            if (cellCount < 2 || cellCount > 3)
            {
                return false;
            }
            else if (cellCount == 3)
            {
                return true;
            }
            else
            {
                return boolArray[xPos, yPos];
            }
        }
    }
}
