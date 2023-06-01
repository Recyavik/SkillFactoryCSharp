namespace Module_7_2_7
{
/*    Создайте схему классов A, B, C, D и E таким образом, 
 *    чтобы B наследовался от A, С от A, D от B и E от C.А также:
Добавьте в класс A виртуальный метод Display (void тип, без параметров), 
который будет выводить в консоль "A".
В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
Для класса C переопределите метод Display, чтобы в консоли было "C".
Для D снова скройте метод.
В классе E также скройте метод. */
    class A
    {
        public virtual void Display()
        {
            Console.Write("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.Write("B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.Write("C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.Write("D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.Write("E");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
        }
    }
}