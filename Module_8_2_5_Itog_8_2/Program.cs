using static System.Console;

namespace Module_8_2_5_Itog_8_2
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
        public static void GetFoldersInfo(DirectoryInfo[] folders)
        {
            WriteLine("Папки:");
            foreach (DirectoryInfo folder in folders)
            {
                WriteLine(folder.Name);
            }
            WriteLine();

        }
    }
}