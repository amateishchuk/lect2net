using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Command
    {
        protected IRepository zRepo;

        protected Command(IRepository zr)
        {
            zRepo = zr;
        }
        public abstract void Execute();
    }
}
