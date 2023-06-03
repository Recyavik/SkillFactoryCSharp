namespace Module_7_5_2
{
    class Helper
    {
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = Helper.Sum(1, 2, 3);
            Console.WriteLine(sum);
        }
    }
}