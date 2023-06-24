using System;

namespace Module_9_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Исключения
            Exception exception = new Exception("Произошло исключение в БД");
            exception.Data.Add("Дата создания исключения", DateTime.Now);

            exception.HelpLink = "www.google.com";
        }
    }
}