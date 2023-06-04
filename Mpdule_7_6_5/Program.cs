namespace Mpdule_7_6_5
{
    class Generic<T1, T2, T3>
    {
        public T1 Field; // Поле типа T1

        public T2 Property { get; set; } // Свойство типа T2

        public void Method(T3 param) // Параметр типа T3
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Generic<object, int, string> generic = new Generic<object, int, string>();
        }
    }
}