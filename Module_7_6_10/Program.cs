namespace Module_7_6_10
{
    class BaseClass<T>
    {
        public T Field;
    }
    class DerivedClass<T> : BaseClass<int>
    {
        public T Property { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass<string> derived = new DerivedClass<string>();
            derived.Field = 13;     // Тип int
            derived.Property = "22";	// Тип string
        }
    }
}