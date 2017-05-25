using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LionFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string nickname)
        {
            return new Lion(nickname);
        }
    }
}
