namespace Module_9_1_3
{
    internal class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            try
            {
                int result = Division(7, 0);
                Division('7', 0);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя...");
                }
                else
                {
                    Console.WriteLine("Непредвиденная ошибка в приложении");
                }
            }
            finally
            {
                Console.WriteLine("Блок finally сработал!");
            }
            Console.ReadLine();

        }
    }
}