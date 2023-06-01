namespace Module_7_2_13
{
    class Book
    {
        public string Name;
        public string Author;
    }

    class BookCollection
    {
        private Book[] collection;

        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public Book this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }

        public Book this[string name]
        {
            get
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i].Name == name)
                    {
                        return collection[i];
                    }
                }
                return null;
            }
        }
    }
class Program
    {
        static void Main(string[] args)
        {

            var array = new Book[] {
            new Book { Name = "Мастер и Маргарита", Author = "М.А. Булгаков" },
            new Book { Name = "Отцы и дети", Author = "И.С. Тургенев" },
        };
            BookCollection collection = new BookCollection(array);

            Console.ReadKey();

            Book book = collection[1];
            Console.WriteLine(book.Name);

            book = collection[-1];
            Console.WriteLine(book.Name);

            book = collection[4];
            Console.WriteLine(book.Name);
            Console.ReadKey();

            book = collection["Мастер и Маргарита"];
            Console.WriteLine(book.Name);
            Console.ReadKey();
        }
    }
}