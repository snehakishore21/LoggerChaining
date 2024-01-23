using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining.Sink
{
    internal class ConsoleObserver: LogObserver
    {
        public override void Log(string msg)
        {
            Console.WriteLine("Console: " + msg);
        }
    }
}
