namespace Module_7_1_8
{
    class BaseClass
    {
        private int value;

        public BaseClass(int value)
        {
            this.value = value;
        }
    }
    class InheritedClass : BaseClass
    {
        private int newValue;

        public InheritedClass(int newValue) : base(100)
        {
            this.newValue = newValue;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}