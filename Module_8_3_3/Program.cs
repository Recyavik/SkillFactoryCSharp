using static System.Console;
using System.IO;
namespace Module_8_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed) // Только Локадьные диски
                {
                    GetDriveInfo(drive);
                    DirectoryInfo root = drive.RootDirectory;
                    DirectoryInfo[] folders = root.GetDirectories();

                    GetFileInfo(root);
                    GetFoldersInfo(folders);

                    WriteLine();
                    WriteLine();
                }
            }
        }
        public static void GetDriveInfo(DriveInfo drive)
        {
            WriteLine($"Название: {drive.Name}");
            WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                WriteLine($"Объем: {drive.TotalSize / 1024 / 1024 / 1024} Гб");
                WriteLine($"Свободно: {drive.TotalFreeSpace / 1024 / 1024 / 1024} Гб");
                WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }
        public static void GetFileInfo(DirectoryInfo rootFolder)
        {
            WriteLine();
            WriteLine("Файлы:");
            foreach (var file in rootFolder.GetFiles())
            {
                WriteLine($"{file.Name} {file.Length}");
            }
        }
        public static void GetFoldersInfo(DirectoryInfo[] folders)
        {
            WriteLine("Папки:");
            foreach (DirectoryInfo folder in folders)
            {
                try
                {
                    WriteLine(folder.Name + $" - размер: {DirectoryExtension.DirSize(folder)}");
                }
               catch (Exception ex) 
                {
                    // Запускать от имени администратора, если нужен доступ ко всем файлам
                    WriteLine(folder.Name + $" - не удалось посчитать размер {ex.Message}");
                }
            }
            WriteLine();

        }
    }
}