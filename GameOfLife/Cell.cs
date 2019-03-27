using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        //private int numberOfTurnAlive = 0;

        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
        }

        public Cell()
        {
            IsAlive = false;
        }
    }
}