namespace Module_6_6_2
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0 && b + c > value)
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0 && a + c > value)
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value > 0 && a + b > value)
                {
                    c = value;
                }
            }
        }

        public double Square(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
            Console.WriteLine("Площадь треугольника = {0}", s);
            return s;
        }

        public double Perimeter(int a, int b, int c)
        {
            double p = (a + b + c);
            Console.WriteLine("Периметр треугольника = {0}", p);
            return p;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.Square(6,4,11);
            t.Perimeter(6,4,11);

            t.Square(6,12,11);
            t.Perimeter(6,12,11);

            Console.ReadKey();
        }
    }
}