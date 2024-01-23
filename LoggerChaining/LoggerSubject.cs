using LoggerChaining.Sink;

namespace LoggerChaining
{
    internal class LoggerSubject
    {
        public static Dictionary<int, HashSet<LogObserver>> Levels = new Dictionary<int, HashSet<LogObserver>>();

        internal void AddObserver(LogObserver consoleObserver, int level)
        {
            Levels.TryAdd(level, new HashSet<LogObserver>());
            Levels[level].Add(consoleObserver);
        }

        internal void NotifyAllObservers(int level, string msg)
        {
            if (!Levels.ContainsKey(level)) { return; }
            foreach (var observer in Levels[level])
            {
                observer.Log(msg);
            }
        }
    }
}
