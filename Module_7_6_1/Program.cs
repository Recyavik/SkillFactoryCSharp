namespace Module_7_6_1
{
    class Order<T>
    {
        public T Number;

        public string Description;

        // ... Другие поля
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order<int> order1 = new Order<int>();
            Order<string> order2 = new Order<string>();

            order1.Number = 1234;
            order2.Number = "NN-1234";

            int number1 = order1.Number;
            string number2 = order2.Number;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}