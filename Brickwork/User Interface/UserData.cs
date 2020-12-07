using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.User_Interface
{
    public class UserData : IUserData //Allows the program logic to interface with the consol
    {
        public string GetData()//Reads data from the console
        {
            return Console.ReadLine();
        }

        public void SendData(string data)//Writes data to the Console
        {
            Console.WriteLine(data);
        }
    }
}
