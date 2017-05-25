using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class InsertAnimalCommand : Command
    {
        public InsertAnimalCommand(IRepository zr) : base(zr)
        {
        }

        public override void Execute()
        {
            Console.Write("Input animal's name: ");
            string nickname = Console.ReadLine();

            Console.Write("Input animal's kind: ");
            string kind = Console.ReadLine();

            zRepo.InsertAnimal(nickname, kind);
        }
    }
}
