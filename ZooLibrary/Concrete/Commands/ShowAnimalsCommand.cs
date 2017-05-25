using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ShowAnimalsCommand : Command
    {
        public ShowAnimalsCommand(IRepository zr) : base(zr)
        {
        }

        public override void Execute()
        {
            zRepo.ShowAnimals();
        }
    }

}
