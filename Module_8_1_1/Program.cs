namespace Module_8_1_1
{
    public class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
       enum DriveType {USB, HDD, CD}
}
    public class Folder
    {
        public Folder(string name)
        {
            Name = name;
        }

        private string Name { get; set; }
        List<string> Files { get; set; } = new List<string>();

        void AddFile(string name)
        {
            if (!Files.Contains(name))
                Files.Add(name);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}