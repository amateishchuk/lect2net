using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Lion : Animal
    {
        public Lion(string nickname) : base(nickname)
        {
            health = 5;
            MAXHEALTH = 5;
        }
    }
}
