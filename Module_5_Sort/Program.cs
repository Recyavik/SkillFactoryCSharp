namespace Module_5_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10, 10];
            arr = GetArrayConsole(3, 2);
            ShowArray(arr,true);
            
        }
        static int[,] GetArrayConsole(int n, int m) 
        { 
            var arr = new int[n, m];
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write("Введите [{0},{1}] элемент массива: ", i + 1, j + 1);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            ShowArray(arr);
            return arr;
        }

        static void ShowArray(int[,] arr, bool isSort = false)
        {
            if (isSort)
            {
                SortComplexArray(arr);
            }
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