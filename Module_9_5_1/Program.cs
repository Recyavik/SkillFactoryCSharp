namespace Module_9_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено не коректное значение");

                }
            }
        }
        static void ShowNumber(int value)
        {
            switch (value)
            {
                case 1: Console.WriteLine("Ввели: 1"); break;
                case 2: Console.WriteLine("Ввели: 2"); break;
            }   
        }
    }

    class NumberReader
    {
        public delegate void NumberReaderDelegate(int value);
        public event NumberReaderDelegate NumberReaderEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите 1 или 2");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value != 1 && value != 2)
            {
                throw new FormatException();
            }
            NumberEntered(value);
        }
        protected virtual void NumberEntered(int value)
        {
            NumberReaderEvent?.Invoke(value);
        }

    }
}