namespace Module_7_3_1
{
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }
    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Николай", true);
            Guest guest = new Guest("Андрей", new DateTime(2020, 11, 05));

            Person person = employee;
            person.DisplayName();
            employee.DisplayName();

            person = guest;
            person.DisplayName();
            employee.DisplayName();
        }
    }
}