using static System.Console;
namespace Module_8_5_Itog_Task1
{
    //Напишите программу, которая чистит нужную нам папку от файлов  и папок,
    //которые не использовались более 30 минут
    internal class Program
    {
        public static void DeleteFiles(string pathFolder, int time)
        {
            WriteLine($"Удаляем файлы в папке {pathFolder}: ");
            try
            {
                DirectoryInfo dr = new(pathFolder);
                TimeSpan interval = TimeSpan.FromMinutes(time);
                DateTime dtNow = DateTime.Now;
                foreach (FileInfo fl in dr.GetFiles())
                {
                    DateTime dt = File.GetLastWriteTime(fl.FullName);
                    var timeLife = dtNow - dt;
                    WriteLine(interval.ToString() + " и " + timeLife.ToString());
                    if (timeLife >= interval)
                    {
                        WriteLine(fl);
                        fl.Delete();
                    }
                    else
                    {
                        WriteLine(fl + " - файл - создан недавно, удалению не подлежит");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Проблема: {ex.Message} удаление файлов невозможно");
            }
        }
        public static void DeleteFolders(string pathFolder, int time)
        {
            WriteLine($"Удаляем вложенные папки каталога {pathFolder}: ");
            try
            {
                DirectoryInfo dr = new(pathFolder);
                TimeSpan interval = TimeSpan.FromMinutes(time);
                DateTime dtNow = DateTime.Now;
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    DateTime dt = Directory.GetLastWriteTime(dir.FullName);
                    var timeLife = dtNow - dt;
                    WriteLine(interval.ToString() + " и " + timeLife.ToString());
                    if (timeLife >= interval)
                    {
                        WriteLine(dir);
                        dir.Delete(true);
                    }
                    else
                    {
                        WriteLine(dir + " - каталог создан недавно, удалению не подлежит");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Проблема: {ex.Message} удаление каталогов невозможно");
            }
        }
        static void Main(string[] args)
        {
            DeleteFiles(@"C://SF/", 1);
            DeleteFolders(@"C://SF/", 1);
        }
    }
}