namespace Module_10_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file = new FileInfo();
            IBanaryFile banaryFile = new FileInfo();
            FileInfo fileInfo = new FileInfo();

            file.ReadFile();

            banaryFile.ReadFile();
            banaryFile.OpenBinaryFile();

            fileInfo.Seach("Строка поиска");

            Console.ReadLine();
        }
    }
    public interface IFile
    {
        void ReadFile();
    }
    public interface IBanaryFile
    {
        void ReadFile();
        void OpenBinaryFile();
    }
    public class FileInfo : IFile, IBanaryFile
    {
        void IBanaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Открываем бинарный файл");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Читаем текстовый файл");
        }
        void IBanaryFile.ReadFile()
        {
            Console.WriteLine("Читаем бинарный файл");
        }

        public void Seach(string text)
        {
            Console.WriteLine("Начался поиск текста в файле");
        }
    }
}