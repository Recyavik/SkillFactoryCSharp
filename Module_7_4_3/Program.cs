using Module_7_4_3;

namespace Module_7_4_3
{

    // Агрегация
    
   public class A 
    {
    }
public class B
{
    public A a;

    public B(A a)
    {
        this.a = a;
    }
}
    // Композиция
  public class KA {}

public class KB
{
    public KA a;

    public KB()
    {
        a = new KA();
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}