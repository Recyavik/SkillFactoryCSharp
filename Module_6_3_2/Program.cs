namespace Module_6_3_2
{
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.PrintStatus();
            bus.Load = 2;
            bus.PrintStatus();
            bus.Load = null;
            bus.PrintStatus();
        }
    }
}