namespace Module_6_5_2
{
    class Circle
    {
        public double radius;

        public double Square()
        {
            double s = radius * radius * double.Pi;
            Console.WriteLine("Площадь круга = {0}", s);
            return s;
        }

        public double Length()
        {
            double l = 2 * radius * double.Pi;
            Console.WriteLine("Длина окружности = {0}", l);
            return l;
        }
    }

    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public double Square()
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c) / 2;
                double s = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
                Console.WriteLine("Площадь треугольника = {0}", s);
                return s;
            }
            else
            {
                Console.WriteLine("Треугольник не существует!");
                return 0;
            }
        }

        public double Perimeter()
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c);
                Console.WriteLine("Периметр треугольника = {0}", p);
                return p;
            }
            else
            {
                Console.WriteLine("Треугольник не существует!");
                return 0;
            }
        }
    }

    class Squares
    {
        public int side;

        public double Square()
        {
            int s = side * side;
            Console.WriteLine("Площадь квадрата = {0}", s);
            return s;
        }

        public double Perimeter()
        {
            double p = side * 4;
            Console.WriteLine("Периметр квадрата = {0}", p);
            return p;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle okr = new Circle();
            okr.radius = 12;
            okr.Square();
            okr.Length();

            Triangle t = new Triangle();
            t.a = 6;
            t.b = 4;
            t.c = 11;
            t.Square();
            t.Perimeter();

            t.a = 6;
            t.b = 12;
            t.c = 11;
            t.Square();
            t.Perimeter();

            Squares q = new Squares();
            q.side = 10;
            q.Square();
            q.Perimeter();
        }
    }
}