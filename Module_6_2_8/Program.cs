using System.Security.Cryptography;

namespace Module_6_2_8
{
    class Rectangle
    {
        public int a;
        public int b;

        public decimal Square()
        {
            return a * b;
        }

        public Rectangle(int da, int db)
        {
            a = da;
            b = db;
        }
        public Rectangle(int da)
        {
            a = da;
            b = da;
        }
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle(5);
            Rectangle r2 = new Rectangle(7,12);
            Console.WriteLine(r.Square());
            Console.WriteLine(r1.Square());
            Console.WriteLine(r2.Square());
        }
    }
}