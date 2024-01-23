using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining.Sink
{
    internal class FileObserver : LogObserver
    {
        public override void Log(string msg)
        {
            Console.WriteLine("File: " + msg);
        }
    }
}
