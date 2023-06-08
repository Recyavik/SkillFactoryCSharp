namespace Module_8_2_1
{

    internal class Program
    {
        static void GetCatalogs()
        {
            string dirName = @"C:\\"; // Прописываем путь к корневой директории Windows (для MacOS скорее всего тут будет @"/")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
        }
    }
}