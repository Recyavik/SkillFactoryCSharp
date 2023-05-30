using System.Runtime.InteropServices;

namespace Module_6_5
{
    class Car
    {
        // Свойства и параметры
        public double Fuel;
        public int Mileage;
        
        //Конструктор 1
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        // Конструктор 2
        public Car(double f, int m)
        {
            Fuel = f;
            Mileage = m;
        }

        //Метод
        public int Move(ref double Fuel, int km)
        {
            // Move a kilometer
            Mileage += km;
            if (Fuel != 0)
            {
                Fuel -= 0.5 * km;
            }
            else
            {
                Console.WriteLine("Не можем ехать, нет топлива ");
                Fuel = 0;
            }
            return Mileage;
        }
        // Метод
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car outlender = new Car(70, 25);
            outlender.Move(ref outlender.Fuel, 5);  
            Console.WriteLine("Осталось топлива {0}, пробег {1} км.",outlender.Fuel, outlender.Mileage);
            outlender.Move(ref outlender.Fuel, 5);
            Console.WriteLine("Осталось топлива {0}, пробег {1} км.", outlender.Fuel, outlender.Mileage);

        }
    }
}