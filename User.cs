using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod3_4
{
    internal class User
    {
        public User()
        {
            Name = string.Empty;
            PhoneNumber = string.Empty;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return Name + " " + PhoneNumber;
        }
    }
}

