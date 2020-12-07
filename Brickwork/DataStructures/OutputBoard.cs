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

        public string[] ReturnFancyBoard() //Return each board row as a string in a string array where each brick is surrounded with "*"
        {
            string[] output = new string[BoardY*2+1];//Contains the string that will be outputed
            output[0] = new string('*', BoardY * 2 + 1);
            StringBuilder outputTopRow = new StringBuilder();//Contains the current top row
            StringBuilder outputBottomRow = new StringBuilder();//Contains the current bottom row
            for (int i = 0; i < BoardX; i++)
            {
                outputTopRow.Append("*");
                outputBottomRow.Append("*");

                for (int j = 0; j < BoardY; j++)
                {
                    outputTopRow.Append(BoardData[i, j].ToString());
                    if (j+1<BoardY)
                    {
                        if (BoardData[i,j]==BoardData[i,j+1])
                        {
                            outputTopRow.Append(" ");
                        }
                        else
                        {
                            outputTopRow.Append("*");
                        }
                    }
                    else
                    {
                        outputTopRow.Append("*");
                    }
                    if (i+1<BoardX)
                    {
                        if (BoardData[i,j]==BoardData[i+1,j])
                        {
                            outputBottomRow.Append(" ");
                        }
                        else
                        {
                            outputBottomRow.Append("*");
                        }
                    }
                    else
                    {
                        outputBottomRow.Append("*");
                    }
                    outputBottomRow.Append("*");
                }
                output[i*2+1] = outputTopRow.ToString();
                output[i*2+2] = outputBottomRow.ToString();
                outputTopRow.Clear();
                outputBottomRow.Clear();
            }
            return output;
        }
    }
}
