namespace Module_9_4_1
{
    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
        }
        class BMW : Car { }
        delegate Car CarDelegate(string name);
        static void Main(string[] args)
        {
            CarDelegate carDelegate;
            carDelegate = BuildBMW; // ковариантность
            Car c = carDelegate("X6");
            Console.WriteLine(c.Model);
            Console.Read();
        }
        private static BMW BuildBMW(string model)
        {
            return new BMW { Model = model };
        }
    }
}