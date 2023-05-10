namespace Module_4_3_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Размерность массива 
            var arr22 = new int[] { 1, 2, 3, 4 };
            var l = arr22.Length;

            //Разные виды инициализации массива
            int[] arr1 = new int[4] { 1, 2, 3, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 5 };
            int[] arr3 = new[] { 1, 2, 3, 5 };
            int[] arr4 = { 1, 2, 3, 5 };

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000,
            minIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);
            Console.WriteLine("Введите своё имя");

            var name = "";
            name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array[0, 0]);
            for (int i = 0; i < array.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1)+1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            // Соритровка массива
            var arr = new int[] { 5, 6, 8, 1, 3, 4 };
            int buffer;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j  < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        buffer = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buffer;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            // Зубчатый массив 
            int[][] ar = new int[3][];

            ar[0] = new int[2] { 1, 2 };
            ar[1] = new int[3] { 1, 2, 3 };
            ar[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in ar)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
