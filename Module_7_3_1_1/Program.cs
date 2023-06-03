namespace Module_7_3_1_1
{
    abstract class FourLeggedAnimal
    {
        public virtual void Describe()
        {
            Console.WriteLine("Это неизвестное животное");
        }
    }

    class Dog : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override void Describe()
        {
            Console.WriteLine("Это животное - кошка");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Describe(); // Собака
            cat.Describe(); // Неизвестное животное
            FourLeggedAnimal animal = dog;
            animal.Describe();

            animal = cat; // Собака
            animal.Describe(); // Неизвестное животное
        }
    }
}