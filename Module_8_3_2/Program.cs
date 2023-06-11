namespace Module_8_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new FileInfo(@"E:\\Develop\C#\SkillFactoryCSharp\SkillFactoryCSharp\Module_8_3_2\Program.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string? str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);

            }
        }
    }
}// Время запуска: 11.06.2023 18:48:34
// Время запуска: 11.06.2023 18:48:44
