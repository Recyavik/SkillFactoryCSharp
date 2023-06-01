namespace Module_7_2_12
{
/*    Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора 
 *    был новый экземпляр класса Obj, а операции производились над полем Value
*/
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj { Value = 12 };
            
            Console.WriteLine(obj.Value + obj.Value);
        }
    }
}