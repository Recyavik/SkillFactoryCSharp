namespace Module_10_1_4
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Manager : IManager
    {
        public void Create()
        {
        }

        public void Read()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
    public interface IManager
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}