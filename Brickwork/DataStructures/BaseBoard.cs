using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Boards
{
    public abstract class BaseBoard
    {
        public int[,] BoardData { get; set; }
        public int BoardX { get; set; }
        public int BoardY { get; set; }

        public BaseBoard(int x,int y)
        {
            BoardX = x;
            BoardY = y;
            BoardData = new int[x,y];
        }
    }
}
