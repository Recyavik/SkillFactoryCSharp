namespace Module_7_2_8
{
    internal class Program
    {
        static long Sum(long a, long b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            double a = 5.2, b = 10.0;
            double answer = Sum(a,b);
            Console.WriteLine(answer);
        }
    }
}