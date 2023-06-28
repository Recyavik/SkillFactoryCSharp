namespace Module_10_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public interface ICalculator
        {
            // void Solve(int number);  
            void Solve(int numberOne, int numberTwo);
        }
        public class BaseCalculator : ICalculator 
        { 
            public void ICalculator.Solve(int number) 
            {

            }
            public void ICalculator.Solve(int numberOne, int numberTwo)
            {

            }
            
        }
    }
}