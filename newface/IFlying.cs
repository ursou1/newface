using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    interface IFlying
    {
        public void Fly()
        {
            Console.WriteLine(this + " летит в новую точку");
        }
    }
}
