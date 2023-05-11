using System.Drawing;

namespace Module_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Viktor", 35);

            Console.Write("Сколько запомнить цветов ");
            int countArray = int.Parse(Console.ReadLine());
            var favcolors = new string[countArray];

            favcolors = GetArrColors(name, countArray);

            Console.WriteLine("Ваши цвета:");
            for (int i = 0; i < favcolors.Length; i++)
            {
                ShowColors(name, favcolors[i]);
            }


        }
        static void ShowColors(string name, string color)
        {
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.WriteLine("{0} color is {1}!", name, color);
        }

        static string[] GetArrColors(string name, int count)
        {
            var favcolors = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}, напишите свой {1} любимый цвет на английском с маленькой буквы" , name, i + 1); ; ;
                var color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                favcolors[i] = color;
            }
            return favcolors;
        }
    }
}