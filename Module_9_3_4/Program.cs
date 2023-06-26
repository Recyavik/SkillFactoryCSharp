namespace Module_9_3_4
{
    internal class Program
    {
        delegate void CalculateDelegate(int a, int b);

        static void Main(string[] args)
        {
            CalculateDelegate cD = CalculatePlus;
            cD += CalculateMinus;
            cD.Invoke(100, 30);
        }
        static void CalculatePlus(int a, int b) 
        { 
            Console.WriteLine(a + b);
        }
        static void CalculateMinus(int a, int b) 
        {
            Console.WriteLine(a - b);
        }
    }
}