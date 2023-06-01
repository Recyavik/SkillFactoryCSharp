namespace Module_7_2_4
{
    class Citizen
    {
        public virtual double Age
        { get; 
          set;
        }
        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }
    class CivilServat: Citizen
    {
        private double age;
        public override double Age 
        { 
        get 
          { 
            return age;
          }
        set 
            {
                if (age <18) 
                {
                    Console.WriteLine("Для работы госслужащим гражданин болжен быть не моложе 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    class President: CivilServat
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин болжен быть не моложе 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();    // метод класса A
            b.Display();    // метод класса B
            ((A)b).Display();  // метод класса B

            c.Display();    // метод класса C
            ((A)c).Display();  // метод класса B
            ((B)c).Display();	// метод класса B
        }
    }
}