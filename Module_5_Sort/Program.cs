namespace Module_5_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3}, { -8, 8, 1, 1, 2, -3} };

            SortComplexArray(arr);
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                    Console.WriteLine();
            }
        }
        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }
    }
}