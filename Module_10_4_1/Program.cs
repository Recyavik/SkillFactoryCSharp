namespace Module_10_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGaragManager<Car, Garage> garagMenadger = new GarageManagerBase();
            IGaragManager<Bike, Garage> garagMenadger2 = new GarageManagerBase(); // Проверка контравариантности
            IGaragManager<Bike, House> garagMenadger3 = new GarageManagerBase(); // Проверка ковариантности
        }
    }
    public class Car
    {

    }
    public class Bike : Car // Проверка контравариантности
    {

    }
    public class House
    {

    }
    public class Garage : House // Проверка ковариантности
    {

    }
    public interface IGaragManager<in T, out Z>
    {
        Z GetGarageInfo();
        void Add(T car);
    }
    public class GarageManagerBase : IGaragManager<Car, Garage>
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}