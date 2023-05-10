namespace Module_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);

            Console.WriteLine(result);


            int currentDayInYear = 293;
            bool isLeapYear = false;
            bool isWinter = !isLeapYear & (currentDayInYear >= 335 | currentDayInYear <= 59) |
                !isLeapYear & (currentDayInYear >= 336 | currentDayInYear <= 60);
            Console.WriteLine("Текущее время года зима {0}", isWinter);
        
            int A = 3;
            int B = 6;
            double X = 3.2;
            double Y = 0;

            bool C = (A < B) | (X > Y);

            var a = 5 + 6;
            var b = 7 + 8;

            var c = (b != a) & (b > a + 1); // вычисляю оба условия в любом случае
            var d = (b != a) && (b > a + 1); // вычисляю сначала одно, а потом посмотрим 

            Console.WriteLine(c);
            Console.WriteLine(d);

            a = 6;
            b = 7;
            c = (a < b) ^ (a != b); // исключающее или 
            Console.WriteLine(c);

            var inv = true;
            result = !inv;
            Console.WriteLine(result);

            a = 6;
            b = 6;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            // Вложенные условия

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }
            Console.ReadKey();
        }
    }
}