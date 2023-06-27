namespace Module_10_1_2
{
    internal class Program
    {
        static ILogger? Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var woker1 = new Worker1(Logger);
            var woker2 = new Worker2(Logger);
            var woker3 = new Worker3(Logger);

            woker1.Work();
            woker2.Work();
            woker3.Work();

        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Event(string message)
        {
            // Возможна отправка в базу даных или на почту
            Console.WriteLine(message);
        }
        public void Error(string message)
        {
            // Возможна отправка в базу даных или на почту
            Console.WriteLine(message);
        }
    }
    public interface IWorker
    {
        void Work();
    }
}