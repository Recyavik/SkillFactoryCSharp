using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Module_8_4_2
{
    [Serializable] //   Атрибут сериализации
    class Person
    {
        // Простая модель класса
        public string Name { get; set; }
        public int Year { get; set; }

        // Конструктор
        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
    [Serializable]
    class Pet
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Pet(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            var person = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new("myPets.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Объект сериализован");
                fs.Close();
            }
            
            // десериализация
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                var newPet = (Pet)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
                fs.Close();
            }
            Console.ReadLine();
        }
    }
}