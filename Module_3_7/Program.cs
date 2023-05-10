namespace Module_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age);
            Console.ReadKey();
        }
    }
}