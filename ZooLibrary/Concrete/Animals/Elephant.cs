using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Elephant : Animal
    {
        public Elephant(string nickname) : base(nickname)
        {
            health = 7;
            MAXHEALTH = 7;
        }
    }
}
