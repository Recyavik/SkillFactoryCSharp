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

        }
    }
}