using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DeleteAnimalCommand : Command
    {
        public DeleteAnimalCommand(IRepository zr) : base(zr)
        {
        }

        public override void Execute()
        {
            Console.Write("Input animal's name: ");
            string nickname = Console.ReadLine();

            zRepo.DeleteAnimal(nickname);
        }
    }
}
