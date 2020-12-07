using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.DataStructures
{
    public class OutputBoard :BaseBoard //Class to hold the out board
    {
        public OutputBoard(int x, int y) : base(x, y)//Creats X*Y board
        {
        }

        public string[] ReturnBoard()//Return each board row as a string in a string array
        {
            string[] output = new string[BoardY];//Contains the string that will be outputed
            StringBuilder outputRow = new StringBuilder();//Contains the current row
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
