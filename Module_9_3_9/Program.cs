namespace Module_9_3_9
{
    internal class Program
    {
        public class AnonymousMethods
        {
            public delegate string GreetingsDelegate(string name);

            static void Main(string[] args)
            {
                GreetingsDelegate gd = delegate (string name)
                {
                    return "Привет @" + name + " и добро пожаловать на SkillFactory!";
                };
                string GreetingsMessage = gd.Invoke("Viktor");
                Console.WriteLine(GreetingsMessage);
                Console.ReadKey();
            }
        }
    }
}