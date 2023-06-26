namespace Module_9_4_2
{
    internal class Program
    {
        public delegate Animal HandlerMethod();
        delegate void DogInfo(Dog dog);

        public static Animal AnimalHander()
        {
            return null;
        }

        public static Dog DogHander()
        {
            return null;
        }
        static void Main(string[] args)
        {
            DogInfo dogInfo = GetAnimalInfo;
            dogInfo.Invoke(new Dog());

            HandlerMethod hM = AnimalHander;
            HandlerMethod hD = DogHander;
        }
        public static void GetAnimalInfo(Animal p)
        {
            Console.WriteLine(p.GetType());
        }

    }
    class Animal { }
    class Dog : Animal { }
}