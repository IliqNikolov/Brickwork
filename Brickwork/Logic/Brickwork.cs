using Brickwork.DataStructures;
using Brickwork.User_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.Logic
{
    public class Brickwork //The main logic class
    {
        private InputBoard Input;//User input board
        private OutputBoard WorkBoard;//Program output
        private int M;//User input for M
        private int N;//User input for N

        public void Run(IUserData user)//The main function
        {
            string[] bricks = GetUserData(user);//User brick layer
            Validate();
            Input = new InputBoard(M, N,bricks);
            WorkBoard = new OutputBoard(M, N);
            LayBricks();
            ReturnOutput(user);
        }

        private string[] GetUserData(IUserData user)//Parses user data
        {
            string line = user.GetData();//Current line of the user input
            M = int.Parse(line.Split(" ")[0]);
            N = int.Parse(line.Split(" ")[1]);
            string[] bricks = new string[M];//User brick data
            for (int i = 0; i < M; i++)
            {
                bricks[i] = user.GetData();
            }
            return bricks;
        }

        private void Validate()//Validates user input
        {
            if (M<2 || M>98 || M%2==1 || N<2 || N>98 || N%2==1)
            {
                throw new Exception("Invalid M or N");
            }
        }
        private void LayBricks()//Lays the 2nd layer. Since all boards can be solved there is no point of returning -1
        {
            int brickCounter = 1;//The number of the next brick
            for (int i = 0; i < M-1; i+=2)
            {
                for (int j = 0; j < N-1; j+=2)
                {
                    if (Input.BoardData[i,j]==Input.BoardData[i+1,j] || Input.BoardData[i, j+1] == Input.BoardData[i + 1, j+1])
                    {
                        WorkBoard.BoardData[i, j] = brickCounter;
                        WorkBoard.BoardData[i, j+1] = brickCounter;
                        brickCounter++;
                        WorkBoard.BoardData[i+1, j] = brickCounter;
                        WorkBoard.BoardData[i+1, j + 1] = brickCounter;
                        brickCounter++;
                    }
                    else
                    {
                        WorkBoard.BoardData[i, j] = brickCounter;
                        WorkBoard.BoardData[i+1, j] = brickCounter;
                        brickCounter++;
                        WorkBoard.BoardData[i , j + 1] = brickCounter;
                        WorkBoard.BoardData[i + 1, j + 1] = brickCounter;
                        brickCounter++;
                    }
                }
            }
        }

        private void ReturnOutput(IUserData user)//Returns the new board to the user
        {
            string[] output;//For the formatted output
            if (Config.IsFancyOutputActive)
            {
                output = WorkBoard.ReturnFancyBoard();
            }
            else
            {
                output = WorkBoard.ReturnBoard();
            }
            foreach (string str in output)
            {
                user.SendData(str);
            }
        }

    }
}
