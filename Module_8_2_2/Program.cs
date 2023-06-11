namespace Module_8_2_2
{
    internal class Program
    {

        static void CreateCatalog(string nameCatalog)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:/LessonC#/");
            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory(nameCatalog);
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }

        static void Main(string[] args)
        {
            CreateCatalog("NewFolderLessonC#");
            Console.WriteLine("Каталог создан");
            Console.ReadKey();
            try
            {
                DirectoryInfo dirInfo = new(@"C:/LessonC#/");
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}