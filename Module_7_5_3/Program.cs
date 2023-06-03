using System.Runtime.Intrinsics;

namespace Module_7_5_3
{
    class Helper
    {
        public int v1;
        public int v2;

        public static void Swap(ref int v1, ref int v2)
        { 
            int b;
            b = v1;
            v1 = v2;
            v2 = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);           /*передача num1 и num2 в метод*/
            

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
        }
    }
}