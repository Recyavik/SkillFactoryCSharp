namespace Module_9_3_11
{
    internal class Program
    {
        delegate int Calculate(int a, int c);
        static void Main(string[] args)
        {
            Calculate calculation = (x, y) => x + y;
            Console.WriteLine(calculation(10, 20));
            Console.WriteLine(calculation(40, 20));
            Console.Read();
        }
    }
}