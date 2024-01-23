using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining.Category
{
    internal abstract class IAbstractLogger
    {
        public IAbstractLogger NextLogger { get; set; }

        public int Level { get; set; }

        public void LogMessage(int level, string msg, LoggerSubject loggerSubject)
        {
            if(this.Level == level)
            {
                Display(msg, loggerSubject);
            }
            if(this.NextLogger != null)
            {
                this.NextLogger.LogMessage(level, msg, loggerSubject);
            }
        }

        public abstract void Display(string msg, LoggerSubject loggerSubject);    
    }
}
