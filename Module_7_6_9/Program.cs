namespace Module_7_6_9
{
    /*Установите ограничения на универсальные типы в классе Car.Такие, чтобы 
     * поле Engine могло принимать тип ElectricEngine и GasEngine, 
     * а параметр newPart метода ChangePart мог бы принимать только типы частей машины 
     * (Battery, Differential, Wheel).
*/
    class Engine
    { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }
    class CarPart { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}