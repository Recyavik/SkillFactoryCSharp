namespace Module_9_3_2
{
    internal class Program
    {
        delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calcDelegate = Calculate;

            int resultOne = calcDelegate.Invoke(100, 30);
            Console.WriteLine(resultOne);

            int resultTwo = calcDelegate(100, 30);
            Console.WriteLine(resultTwo);


            Console.Read();
        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}