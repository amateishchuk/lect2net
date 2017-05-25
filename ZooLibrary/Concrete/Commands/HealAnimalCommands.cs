using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class HealAnimalCommand : Command
    {
        public HealAnimalCommand(IRepository zr) : base(zr)
        {
        }

        public override void Execute()
        {
            Console.Write("Input animal's name: ");
            string nickname = Console.ReadLine();

            zRepo.HealAnimal(nickname);
        }
    }
}
