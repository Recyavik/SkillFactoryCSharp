namespace Module_5_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(8, -3));
        }

        static decimal PowerUp(int x, int y) 
        {
            if (x == 0 && y != 0) return 0;
            else
                if (y == 0) return 1;
            else
                if (y == 1) return x;
            else
                if (y < 0) return x * 1/PowerUp(x, (y*-1 - 1));
            else return x * PowerUp(x, y - 1);

        }
    }
}