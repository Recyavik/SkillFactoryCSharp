namespace Module_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            int res = byte.MaxValue + int.MinValue;
            Console.WriteLine(res);
            

        }
    }
}