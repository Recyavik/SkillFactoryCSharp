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
            Console.WriteLine("Hello, World!");
        }
    }
}