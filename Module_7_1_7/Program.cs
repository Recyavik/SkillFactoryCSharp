namespace Module_7_1_7
{
    class SmartHelper 
    {
        private string name;

    public SmartHelper(string name)
    {
        this.name = name;
    }

    public void Greetings(string name)
    {
        Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }
    }
}