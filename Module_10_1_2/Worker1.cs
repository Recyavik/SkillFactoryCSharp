namespace Module_10_1_2
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Woker 1 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Woker 1 завершил свою работу");
        }
    }
    public class Worker2 : IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Woker 2 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Woker 2 завершил свою работу");
        }
    }
    public class Worker3 : IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Woker 3 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Woker 3 завершил свою работу");
        }
    }
}
