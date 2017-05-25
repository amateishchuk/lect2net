using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Tiger : Animal
    {
        public Tiger(string nickname) : base(nickname)
        {
            health = 4;
            MAXHEALTH = 4;
        }
    }
}
