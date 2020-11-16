using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    interface ISwimming
    {
        public void Swim()
        {
            Console.WriteLine(this + " плывет в новую точку");
        }
    }
}
