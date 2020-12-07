using Brickwork.Boards;
using System;

namespace Brickwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = new string[3];
            temp[0] = "1 2 3 4";
            temp[1] = "5 6 7 8";
            temp[2] = "9 10 11 12";
            InputBoard test = new InputBoard(3, 4, temp);
            OutputBoard output = new OutputBoard(3, 4);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    output.BoardData[i, j] = test.BoardData[i, j]+1;
                }
            }
            foreach (string str in output.ReturnBoard())
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
