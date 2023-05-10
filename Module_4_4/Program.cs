namespace Module_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anketa = (name: "Jane", age: 27);

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            (string name, int age) anketa2;

            Console.Write("Введите имя: ");
            anketa2.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa2.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa2.name);
            Console.WriteLine("Ваш возраст: {0}", anketa2.age);

            Console.ReadKey();
        }
    }
}