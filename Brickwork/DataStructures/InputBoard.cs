using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickwork.Boards
{
    public class InputBoard : BaseBoard
    {
        public InputBoard(int x, int y,string[] userInput) : base(x,y)//Creats X*Y board and fills it
        {
            for (int i = 0; i < BoardX; i++)
            {
                int[] inpurRow = userInput[i].Split(" ").Select(a => int.Parse(a)).ToArray();
                for (int j = 0; j < BoardY; j++)
                {
                    BoardData[i, j] = inpurRow[j];
                }
            }
        }       
    }
}
