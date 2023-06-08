using System;
using System.IO;
namespace Module_8_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize / 1024 / 1024} Mб");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace / 1024 / 1024} Мб");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
        }
    }
}