using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    class Dog:Animal,IWalking
    {
        public string Name { get; set; }

        public Dog(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString() => Name;
    }
}
