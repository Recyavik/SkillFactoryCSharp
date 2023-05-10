using System.Xml.Linq;

namespace Module_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age);
          


            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age);

            Console.Write("Enter your age: ");
            bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your age is {0} ", age);

            Console.Write("Enter your favotit day: ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine(day);

            // Неявная типизация
            var name = "Viktor";
            var answer = 2 + 2;

            age = checked((byte)int.Parse(Console.ReadLine()));
            int intage = age;
            Console.WriteLine("Your name is {0} and age is {1} ", name, intage);
            var howItall = 162;
            var myshoe = 37.5;
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.WriteLine("What is my grouth? {0} sm", howItall);
            Console.WriteLine("What is my shoe size? {0}", myshoe);

            Console.ReadKey();



        }
    }
}