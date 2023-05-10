string MyName = "Jane";
byte MyAge = 27;
bool HaveIApet = true;
double MyShoeSize = 37.5;

Console.WriteLine("My name is " + MyName);
Console.WriteLine("MyAge " + MyAge);
Console.WriteLine("Do I have a pet? " + HaveIApet);
Console.WriteLine("My shoe size is " + MyShoeSize);

Console.WriteLine("IntMin {0} ", int.MinValue);
Console.WriteLine("IntMax {0} ", int.MaxValue);

Console.WriteLine(DayOfWeek.Sunday);
Console.WriteLine((Semaphore)100);

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





