using System.Xml.Linq;

string MyName = "Jane";
byte MyAge = 27;
bool HaveIApet = true;
double MyShoeSize = 37.5;
byte age = 15; 

Console.WriteLine("My name is " + MyName);
Console.WriteLine("MyAge " + MyAge);
Console.WriteLine("Do I have a pet? " + HaveIApet);
Console.WriteLine("My shoe size is " + MyShoeSize);

Console.WriteLine("IntMin {0} ", int.MinValue);
Console.WriteLine("IntMax {0} ", int.MaxValue);

Console.WriteLine(DayOfWeek.Sunday);
Console.WriteLine((Semaphore)100);
Console.WriteLine("\tПривет,\n мир!");
Console.WriteLine($"Мой возраст {age}");

string name = Console.ReadLine();

Console.WriteLine($"{0}\n {1}\n {2}", name, age, MyShoeSize);

Console.ReadKey();

enum DaysofWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sanday
}

enum Semaphore: int 
{
    Red = 100,
    Yellow = 200,
    Green = 300
}





