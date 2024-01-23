using LoggerChaining.Category;

namespace LoggerChaining
{
    internal class Logger
    {
        public static Logger logger;
        public static IAbstractLogger abstractLogger;
        public static LoggerSubject loggerSubject;
     
        public Logger()
        {
            if (logger != null)
                throw new Exception("Object already created");
           
        }

        //Here you can have options in the constructor to choose the type of sink you want to use: i.e. File, Console, Database etc.
        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
                abstractLogger = LogManager.DoLogCategoryChaining();
                loggerSubject = LogManager.AddObservers();
            }
            return logger;
        }

        public void Info(string msg)
        {
            LogMessage(0, msg);
        }

        public void Error(string msg)
        {
            LogMessage(1, msg);
        }
        public void Debug(string msg)
        {
            LogMessage(2, msg);
        }

        private void LogMessage(int level, string msg)
        {
            abstractLogger.LogMessage(level, msg, loggerSubject);
        }
    }
}
