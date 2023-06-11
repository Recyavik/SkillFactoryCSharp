namespace Module_8_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Develop\C#\SkillFactoryCSharp\SkillFactoryCSharp\Module_8_3_1\Program.cs"; // Укажем путь

            // Откроем файл и прочитаем его содержимое
            using StreamReader sr = File.OpenText(filePath);
            string? str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }
    }
}