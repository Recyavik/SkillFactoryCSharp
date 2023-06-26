namespace Module_9_3_1
{
    internal class Program
    {
        public delegate int SumDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 10, 50);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}