namespace Module_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<=5; i++)
            {
                Console.WriteLine(i);
            }

            for (double i = 5.0; i >= 0; i -= 1)
            {
                Console.WriteLine(i);
            }

            int j = 1;
            for (; j <=3 ; )
            {
                Console.WriteLine(j);
                j++;
            }

            int z = 1;
            while (z <= 4) 
            {
                Console.WriteLine(z);
                z++;
            }

            while (z >= 1)
            {
                Console.WriteLine(z);
                z--;
            }

            do
            {
                Console.WriteLine(z);
                z++;
            } while (z != 10);

            do
            {
                Console.WriteLine(z);
                z--;
            } while (z != 0);
            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
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
                t++;
            } while (t < 3);


            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                // number > 0
                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
        }
    }
}