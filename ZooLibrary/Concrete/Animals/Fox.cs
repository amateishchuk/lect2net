using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Fox : Animal
    {
        public Fox(string nickname) : base(nickname)
        {
            health = 3;
            MAXHEALTH = 3;
        }
    }
}
