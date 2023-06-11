using static System.Console;
using System.IO;
namespace Module_8_5_0
{
    class Program
    {
        public static FileInfo cofigFile = new FileInfo(fileName: @"E:\Develop\C#\SkillFactoryCSharp\SkillFactoryCSharp\Module_8_5_0\SystemConfig.txt");
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable) // Только флешки
                {
                    DirectoryInfo root = drive.RootDirectory;
                    DirectoryInfo[] folders = root.GetDirectories();

                    WriteLine($"Сканируем диск {drive.Name}");

                    using (StreamWriter sw = cofigFile.AppendText())
                    {
                        WriteDriveInfo(drive, sw);
                        WriteFileInfo(root, sw);
                        WriteFoldersInfo(folders, sw);
                    }
                    WriteLine("Завершено");
                    WriteLine("----------");
                }
            }
        }
        public static void WriteDriveInfo(DriveInfo drive, StreamWriter sw) // Добавил поток
        {
            sw.WriteLine($"Название: {drive.Name}");
            sw.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                sw.WriteLine($"Объем: {drive.TotalSize / 1024 / 1024 / 1024} Гб");
                sw.WriteLine($"Свободно: {drive.TotalFreeSpace / 1024 / 1024 / 1024} Гб");
                sw.WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }
        public static void WriteFileInfo(DirectoryInfo rootFolder, StreamWriter sw)
        {
            sw.WriteLine();
            sw.WriteLine("Файлы:");
            foreach (var file in rootFolder.GetFiles())
            {
                sw.WriteLine($"{file.Name} {file.Length}");
            }
        }
        public static void WriteFoldersInfo(DirectoryInfo[] folders, StreamWriter sw)
        {
            sw.WriteLine("Папки:");
            foreach (DirectoryInfo folder in folders)
            {
                try
                {
                    sw.WriteLine(folder.Name + $" - размер: {DirectoryExtension.DirSize(folder)}");
                }
                catch (Exception ex)
                {
                    // Запускать от имени администратора, если нужен доступ ко всем файлам
                    sw.WriteLine(folder.Name + $" - не удалось посчитать размер {ex.Message}");
                }
            }
            sw.WriteLine();

        }
    }
}