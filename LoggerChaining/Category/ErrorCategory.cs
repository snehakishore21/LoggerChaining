using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining.Category
{
    internal class ErrorCategory : IAbstractLogger
    {
        public ErrorCategory(int level) { 
            this.Level = level;
        }
        public override void Display(string msg, LoggerSubject loggerSubject)
        {
            loggerSubject.NotifyAllObservers(Level, "ERROR:" + msg);
        }
    }
}
