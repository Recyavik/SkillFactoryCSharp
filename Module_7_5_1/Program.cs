namespace Module_7_5_1
{
    class SimpleClass
    {
        public static int MinValue = 100;

        public int Value;

        public SimpleClass(int value)
        {
            if (value < MinValue)
            {
                Value = MinValue;
            }
            else
            {
                Value = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleClass.MinValue);

            SimpleClass object1 = new SimpleClass(50);
            SimpleClass object2 = new SimpleClass(170);

            Console.WriteLine(object1.Value); // 100 потому что Value < MinValue
            Console.WriteLine(object2.Value); // 170
        }
    }
}