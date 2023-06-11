namespace Module_8_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new(@"C:/LessonC#");
            dirInfo.Create();
            string newPath = "C:/LessonC#2";
            if (dirInfo.Exists && !Directory.Exists("C:/LessonC#2"))
            {
                dirInfo.MoveTo(newPath);
                Console.WriteLine("Каталог перемещен");
            }
        }
    }
}