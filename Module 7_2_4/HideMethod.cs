using VisioForge.Libs.MediaFoundation.OPM;

namespace Module_7_2_4
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Вызов метода класса A");
        }
    }
    class B: A
    {
        public override void Display()
        {
            Console.WriteLine("Вызов метода класса B");
        }
    }
    class C: B
    {
        public new void Display()
        {
            Console.WriteLine("Вызов метода класса C");
        }
    }
    internal class HideMethod
    {
        
    }
}
