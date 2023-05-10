namespace Module_4_3_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];
            for (int i = 0; i<favcolors.Length; i++)
            {
                Console.WriteLine("Введите {0}-й любимый цвет",i+1);
                favcolors[i] = Console.ReadLine();
            }
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
       
    }
}