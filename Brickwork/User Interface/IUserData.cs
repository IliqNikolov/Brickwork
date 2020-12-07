using System;
using System.Collections.Generic;
using System.Text;

namespace Brickwork.User_Interface
{
    public interface IUserData //Detaches program logic from the IO logic
    {
        string GetData();//Input data
        void SendData(string data);//output Data
    }
}
