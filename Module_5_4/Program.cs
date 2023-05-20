namespace Module_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            Matreshka(num);
            Console.ReadKey();
        }
        static int Matreshka(int num)
        {
            num++;

            return Sum(num, 3);
        }
        static int Sum(int num, int num2)
        {
            return num + num2;
        }
 
    }
 }