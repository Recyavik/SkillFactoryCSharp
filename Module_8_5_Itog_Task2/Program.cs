using static System.Console;
using System.IO;
namespace Module_8_5_Itog_Task2
{
    internal class Program
    {
        public static long sizeDelDir = 0;
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
                    if (timeLife >= interval)
                    {
                        WriteLine(fl);
                        sizeDelDir += GetDirInfo.GetDirSize(pathFolder);
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
                long sizeDelDir = 0;
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    DateTime dt = Directory.GetLastWriteTime(dir.FullName);
                    var timeLife = dtNow - dt;
                    if (timeLife >= interval)
                    {
                        sizeDelDir += GetDirInfo.GetDirSize(dir.FullName);
                        WriteLine(dir);
                        // dir.DeleteFolders(dir.FullName, 1);
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
            const string urlPath = @"C://SF/";
            const int timeLife = 1;
            WriteLine("Размер каталога {0} = {1}",urlPath, GetDirInfo.GetDirSize(urlPath));
            DeleteFiles(urlPath, timeLife);
            DeleteFolders(urlPath, timeLife);
            WriteLine("Освобождено в каталоге {0}: {1}", urlPath, sizeDelDir);
            WriteLine("Текущий размер каталога {0} = {1}", urlPath, GetDirInfo.GetDirSize(urlPath));
        }
    }
}