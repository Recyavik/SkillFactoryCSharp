namespace Module_7_6_6
{
    class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
    }
    class Proga
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Obj obj = new Obj();
                obj.Display<int>(345);

                int num1 = 4;
                int num2 = 10;

                Proga.Swap<int>(ref num1, ref num2);

                Console.WriteLine("{0} {1}", num1, num2);
        }
    }
}