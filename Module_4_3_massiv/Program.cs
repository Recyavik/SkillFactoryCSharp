﻿namespace Module_4_3_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Размерность массива 
            var arr = new int[] { 1, 2, 3, 4 };
            var l = arr.Length;

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

            Console.ReadKey();

        }
       
    }
}