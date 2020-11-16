using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    class Butterfly:Animal, IFlying
    {
        public string Name { get; set; }

        public Butterfly(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public override string ToString() => Name;
    }
}
