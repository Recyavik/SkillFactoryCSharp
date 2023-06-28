namespace Module_10_2_4
{
    public class Program
    {
        static void Main()
        {
            var worker = new Worker();
            ((IWorker)worker).Build();
        }
    }

    public class Worker : IWorker
    {
        public void Build()
        {
            throw new NotImplementedException();
        }
    }

    public interface IWorker
    {
        public void Build();
    }
}