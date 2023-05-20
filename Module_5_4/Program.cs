namespace Module_5_4
{

    internal class Program
    {

        static int num1 = 655;
        static int Sum()
        {
            var num2 = 1; 
            return num2 + num1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(num1);
            Console.WriteLine(Sum());
            if (num1 > 0)
            {
                var num3 = 5;
                Console.WriteLine(num1 + num3);
            } 
        }

      
    }

}