using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Board
    {
        public Cell[,] Grid { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Board(int width, int height, List<Cell[,]> startingPattern)
        {
            Width = width;
            Height = height;
            Grid = new Cell[width, height];
            PopulateBoard(startingPattern);
        }

        //Used in unit tests for GetLivingNeighbors()
        public Board(Cell[,] grid)
        {
            Grid = grid;
            Width = grid.GetLength(0);
            Height = grid.GetLength(1);
        }

        //#QUESTION : Best practice, using var or type for method variables? 
        public void PopulateBoard(List<Cell[,]> startingPattern)
        {
            for (var x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    Grid[x, y] = new Cell();
                }
            }
      
            var middleBoardY = (int) Math.Ceiling((double)Height / 2);
            var middleBoardX = (int)Math.Ceiling((double)Width / 2);
            var patternStartX = 13 + startingPattern[0].GetLength(0)/2;


            foreach (Cell[,] letter in startingPattern)
                WriteLetterOnBoard(letter, middleBoardX, middleBoardY, patternStartX+=5);
        }

        private void WriteLetterOnBoard(Cell[,] letter, int middleBoardX, int middleBoardY, int xIncrement)
        {
            for (var x = 0; x < letter.GetLength(0); x++)
            {
                for (var y = 0; y < letter.GetLength(1); y++)
                {
                    bool isAlive = letter[x , y ].IsAlive;
                    Grid[x + xIncrement, y + middleBoardY].IsAlive = isAlive;
                }
            }
        }


        public int GetLivingNeighbors(int xPoint, int yPoint)
        {
            var  livingNeighbors = 0;
            for (var x = -1; x <= 1; x++)
            {
                for (var y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        /*do nothing, as is self*/
                    }
                    else if (x + xPoint < 0 || y + yPoint < 0 || x + xPoint >= Grid.GetLength(0) || y + yPoint >= Grid.GetLength(1))
                    {
                        /*do nothing, as out of bounds of Grid*/
                    }
                    else if (Grid[xPoint + x, yPoint + y].IsAlive)
                    {
                        livingNeighbors++;
                    }
                }
            }
            return livingNeighbors;
        }

        public void UpdateBoard()
        {
            Cell[,] updatedBoard = new Cell[Width, Height];
            for (var x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    var livingNeighbors = GetLivingNeighbors(x, y);
                    var isAlive = CheckCellStatus(Grid[x, y].IsAlive, livingNeighbors);
                    updatedBoard[x, y] = new Cell(isAlive);
                }
            }

            Grid = updatedBoard;
        }

        public static bool CheckCellStatus(bool isAlive, int livingNeighborCount)
        {
            return isAlive ? livingNeighborCount >= 2 && livingNeighborCount <= 3 : livingNeighborCount == 3;
        }
    }
}
