namespace Module_9_3_3
{
    internal class Program
    {
        public delegate void ShowDelegate();
        static void Main(string[] args)
        {

            ShowDelegate showDelegate = ShowMessage1;
            showDelegate += ShowMessage2;
            showDelegate += ShowMessage3;
            showDelegate += ShowMessage4;

            showDelegate.Invoke();

            Console.ReadKey();
        }

        static void ShowMessage1()
        {
            Console.WriteLine("Метод 1");
        }

        static void ShowMessage2()
        {
            Console.WriteLine("Метод 2");
        }

        static void ShowMessage3()
        {
            Console.WriteLine("Метод 3");
        }

        static void ShowMessage4()
        {
            Console.WriteLine("Метод 4");
        }
    }
}