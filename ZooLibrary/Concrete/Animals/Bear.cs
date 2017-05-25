using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Bear : Animal
    {
        public Bear(string nickname) : base(nickname)
        {
            health = 6;
            MAXHEALTH = 6;
        }
    }
}
