namespace Module_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            var data = 5;
            BigDataOperation(arr, ref data);
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;             

            int result = SumNumbers(ref num1, in num2, out num3, num4);

            Console.WriteLine(arr[0]);
            Console.WriteLine(data);

            Console.WriteLine(num3);
            Console.WriteLine(result);
        }

        private static void BigDataOperation(int[] arr, ref int data)
        {
            arr[0] = 4;
            data = 0;
        }

        static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            num1 = 10; // Можно поменять, работает ref
            // num2 = 20; Нельзя изменять, работает in
            num3 = num1 + num2; // Возвращает из метода out
            return num3 * num4; // обычная
        }
    }
}