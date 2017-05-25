using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ChangeStateCommand : Command
    {
        public ChangeStateCommand(IRepository zr) : base(zr)
        {
        }

        public override void Execute()
        {
            zRepo.ChangeStateForRandomAnimal();
        }
        public void Execute(Object obj) // another method for timer
        {
            zRepo.ChangeStateForRandomAnimal();
        }
    }
}
