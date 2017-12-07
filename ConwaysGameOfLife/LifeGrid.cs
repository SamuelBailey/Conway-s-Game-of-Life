using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alea;
using Alea.Parallel;

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

        [GpuManaged]
        public bool[,] CalculateNextFrame()
        {
            bool[,] tempBoolArray = new bool[grid.GetLength(0), grid.GetLength(1)];

            //Parallel.For(0, grid.GetLength(0), (i) =>
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int cellCount = 0;
                int xLength = grid.GetLength(0);
                int yLength = grid.GetLength(1);
                bool[] row = new bool[grid.GetLength(1)];
                Buffer.BlockCopy(rectArray, doubleSize * d2 * rowToGet, target, 0, doubleSize * d2);
                Gpu.Default.For(0, grid.GetLength(1), (j) =>
                //for (int j = 0; j < grid.GetLength(1); j++)
                {
                    //tempBoolArray[j, i] = CalculateCell(j, i, grid);
                    //for (int y = -1; y <= 1; y++)
                    //{
                    //    for (int x = -1; x <= 1; x++)
                    //    {
                    //        if (x != 0 || y != 0)
                    //        {
                    //            int xOffset = (j + x) % grid.GetLength(0);
                    //            int yOffset = (i + y) % grid.GetLength(1);

                    //            if (xOffset < 0)
                    //                xOffset += grid.GetLength(0);
                    //            if (yOffset < 0)
                    //                yOffset += grid.GetLength(1);

                    //            if (grid[xOffset, yOffset])
                    //            {
                    //                cellCount++;
                    //            }
                    //        }
                    //    }
                    //}
                    //if (cellCount < 2 || cellCount > 3)
                    //{
                    //    tempBoolArray[j, i] = false;
                    //}
                    //else if (cellCount == 3)
                    //{
                    //    tempBoolArray[j, i] = true;
                    //}
                    //else
                    //{
                    //    tempBoolArray[j, i] = grid[j, i];
                    //}
                    for (int y = -1; y <= 1; y++)
                    {
                        for (int x = -1; x <= 1; x++)
                        {
                            if (x != 0 || y != 0)
                            {
                                int xOffset = (j + x) % xLength;
                                int yOffset = (i + y) % yLength;

                                if (xOffset < 0)
                                    xOffset += xLength;
                                if (yOffset < 0)
                                    yOffset += yLength;

                                if (grid[xOffset, yOffset])
                                {
                                    cellCount++;
                                }
                            }
                            //tempBoolArray[j, i] = true;
                        }                        
                    }
                });
            }//);

            //for (int i = 0; i < grid.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grid.GetLength(0); j++)
            //    {
            //        tempBoolArray[j, i] = CalculateCell(j, i, grid);
            //    }
            //}
            return tempBoolArray;
        }

        bool CalculateCell(int j, int i, bool[,] grid)
        {
            int cellCount = 0;

            for (int y = -1; y <= 1; y++)
            {
                for (int x = -1; x <= 1; x++)
                {
                    if (x != 0 || y != 0)
                    {
                        int xOffset = (j + x) % grid.GetLength(0);
                        int yOffset = (i + y) % grid.GetLength(1);
            
                        if (xOffset < 0)
                            xOffset += grid.GetLength(0);
                        if (yOffset < 0)
                            yOffset += grid.GetLength(1);
            
                        if (grid[xOffset, yOffset])
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
                return grid[j, i];
            }
        }
    }
}
