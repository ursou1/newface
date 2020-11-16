using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    interface IWalking
    {
        public void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
