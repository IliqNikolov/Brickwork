using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.DataStructures
{
    public abstract class BaseBoard //Base class to hold the data
    {
        public int[,] BoardData { get; set; } //Holds board data
        public int BoardX { get; set; } //Holds board x
        public int BoardY { get; set; } //Holds board y

        public BaseBoard(int x,int y)
        {
            BoardX = x;
            BoardY = y;
            BoardData = new int[x,y];
        }
    }
}
