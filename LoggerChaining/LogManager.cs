using LoggerChaining.Category;
using LoggerChaining.Sink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChaining
{
    internal class LogManager
    {
        internal static LoggerSubject AddObservers()
        {
            LogObserver fileObserver = new FileObserver();
            LogObserver consoleObserver = new ConsoleObserver();
            LoggerSubject loggerSubject = new LoggerSubject();
            loggerSubject.AddObserver(fileObserver, 1);
            loggerSubject.AddObserver(consoleObserver,0);
            loggerSubject.AddObserver(consoleObserver, 1);
            loggerSubject.AddObserver(consoleObserver, 2);
            return loggerSubject;
        }

        internal static IAbstractLogger DoLogCategoryChaining()
        {
            IAbstractLogger infoCategory = new InfoCategory(0);
            IAbstractLogger errorCategory = new ErrorCategory(1);
            infoCategory.NextLogger = errorCategory;
            IAbstractLogger debugCategory = new DebugCategory(2);
            errorCategory.NextLogger = debugCategory;
            return infoCategory;
        }
    }
}
