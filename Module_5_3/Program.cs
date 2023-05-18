namespace Module_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
        }

        private static void BigDataOperation(int[] arr)
        {
            arr[0] = 4;
        }
    }
}