using System;
using static System.Console;
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
            var result = 0;
            try
            {
                result = Division(7, 1);
                result = Division(7, 0);
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    WriteLine("На ноль делить нельзя...");
                }
                else
                {
                    WriteLine("Непредвиденная ошибка в приложении");
                }
            }
            finally
            {
                WriteLine(result);
            }
            ReadLine();

        }
    }
}