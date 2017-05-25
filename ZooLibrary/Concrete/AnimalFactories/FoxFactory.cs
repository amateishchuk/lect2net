using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FoxFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string nickname)
        {
            return new Fox(nickname);
        }
    }
}
