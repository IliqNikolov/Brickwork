using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Boards
{
    public class OutputBoard :BaseBoard
    {
        public OutputBoard(int x, int y) : base(x, y)//Creats X*Y board
        {
        }

        public string[] ReturnBoard()//Return each board row as a string in a string array
        {
            string[] output = new string[BoardY];
            StringBuilder outputRow = new StringBuilder();
            for (int i = 0; i < BoardX; i++)
            {
                for (int j = 0; j < BoardY; j++)
                {
                    outputRow.Append(BoardData[i, j] + " ");
                }
                output[i] = outputRow.ToString().TrimEnd();
                outputRow.Clear();
            }
            return output;
        }
    }
}
