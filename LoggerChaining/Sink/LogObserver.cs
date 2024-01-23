using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining.Sink
{
    internal abstract class LogObserver
    {
        public abstract void Log(string msg);
    }
}
