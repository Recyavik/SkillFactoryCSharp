namespace Module_9_4_1
{
    class Animal
    {
        public string Name
        {
            get;
            set;
        }
    }
    class Penguin : Animal { }

    public class Program
    {

            delegate Animal AnimalDelegate(string name);
            static void Main(string[] args)
            {
                AnimalDelegate animalDelegate;
                animalDelegate = BuildPeguin;
                Animal animal = animalDelegate("Josh");
                Console.WriteLine(animal.Name);
                Console.Read();
            }
        private static Penguin BuildPeguin(string name)
        {
            return new Penguin
            {
                Name = name
            };
        }
    }
}