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

        }
    }
}