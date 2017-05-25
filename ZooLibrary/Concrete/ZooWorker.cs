using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ZooWorker
    {
        public Command Command { private get; set; }
        
        public void Run()
        {
            Command.Execute();
        }
    }
}
