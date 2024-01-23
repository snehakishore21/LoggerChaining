using LoggerChaining;

namespace Declaring_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start awesome Logger");
            Logger logger = Logger.GetLogger();
            logger.Info("this is an info");
            logger.Debug("this is a debug");
            logger.Error("this is an error");
        }
    }
}