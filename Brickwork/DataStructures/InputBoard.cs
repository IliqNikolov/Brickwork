﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickwork.DataStructures
{
    public class InputBoard : BaseBoard //Class to hold the imput board
    {
        public InputBoard(int x, int y,string[] userInput) : base(x,y)//Creats X*Y board and fills it
        {
            for (int i = 0; i < BoardX; i++)
            {
                int[] inpurRow = userInput[i].Split(" ").Select(a => int.Parse(a)).ToArray();//Parses string into int array
                for (int j = 0; j < inpurRow.Length; j++)
                {
                    try
                    {
                        BoardData[i, j] = inpurRow[j];
                    }
                    catch (IndexOutOfRangeException)
                    {

                        throw new Exception("Brick out of range");
                    }
                }
            }
            Validate();
        }
        
        private void Validate() //Validates if there is any brick that is 3 long or high or if there are holes
        {
            for (int i = 0; i < BoardX; i++)
            {
                for (int j = 0; j < BoardY; j++)
                {
                    if (BoardData[i,j]==0)
                    {
                        throw new Exception("Invalid brick placement");
                    }
                    if (i+2<BoardX)
                    {
                        if (BoardData[i,j]==BoardData[i+2,j] && BoardData[i, j]==BoardData[i + 1, j])
                        {
                            throw new Exception("Brick to big");
                        }
                    }
                    if (j+2<BoardY)
                    {
                        if (BoardData[i,j]==BoardData[i,j+2] && BoardData[i, j] == BoardData[i, j + 1])
                        {
                            throw new Exception("Brick to big");
                        }
                    }
                }
            }
        }
    }
}
