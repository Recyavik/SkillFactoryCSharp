namespace Module_7_2
{
    class Car
    {
        public int Mileage;
        public Car()
        {
            Mileage = 0;
        }
        public virtual void Move()
        {
            Console.WriteLine("Вызван метод класса Car");
        }
    }
    enum FuelType
    {
        Gas = 0,
        Electricity
    }
    class HybridCar: Car
    {
        public FuelType FuelType;
        public double Gas;
        public double Electricity;

        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }
        public override void Move() 
        {
            Console.WriteLine("Вызван метод Move класса HyperCar");
            Mileage++;
            switch (FuelType) 
            { 
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
               case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            HybridCar hybridCar = new HybridCar();

            car.Move();         // метод класса Car
            hybridCar.Move();       // метод класса HybridCar
            ((Car)hybridCar).Move();// метод класса HybridCar
        }
    }
}