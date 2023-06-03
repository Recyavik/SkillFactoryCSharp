namespace Module_7_5_5
{
    static class Car
    {
        public static int MinPrice = 100_000;
        public static int MaxPrice;

        static Car()
        {
            Console.WriteLine("Вызван статический конструктор класса Car");
            MaxPrice = 1_000_000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.MaxPrice);
        }
    }
}