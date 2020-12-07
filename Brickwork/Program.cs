using Brickwork.Logic;
using Brickwork.User_Interface;
using System;

namespace Brickwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.Brickwork brickwork = new Logic.Brickwork();//Creates an instance of the main logic class
            brickwork.Run(new UserData());
        }
    }
}
