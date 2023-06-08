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

        private static int GetCountFile()
        {
            int count = 0;
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\" /* Или С:\\ для Windows */ );
                if (dirInfo.Exists)
                {
                    count = (dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return count;
        }
        static void CreateCatalog(string nameCatalog)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:/LessonC#/");
            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory(nameCatalog);
        }
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
            int count = GetCountFile(); // Вызов метода получения количества файлов
            Console.WriteLine(count);
            CreateCatalog("NewFolderLessonC#");
        }
    }
}