namespace Module_5_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));
        }
        static decimal Factorial(int x) 
        { 
            if (x == 0) return 1;
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}