using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Wolf : Animal
    {
        public Wolf(string nickname) : base(nickname)
        {
            health = 4;
            MAXHEALTH = 4;
        }
    }
}
