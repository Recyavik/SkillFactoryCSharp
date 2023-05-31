namespace Module_7_1_11
{
    class Creature { }

    class Animal : Creature { }

    class Human : Creature { }

    class HomoSapiens : Human { }
    internal class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();

            if (secondCreature is Animal)
            {
                Animal animal = secondCreature as Animal;

                if (animal != null)
                {
                    // Использование значения animal
                    Console.WriteLine("Экземпляр имеет тип Animal");
                }
            }
            bool expression;
            expression = secondCreature is Animal;  //true
            expression = secondCreature is Creature;    //true
            expression = secondCreature is object;  //true
            expression = secondCreature is Human;	//false


        }
    }
}