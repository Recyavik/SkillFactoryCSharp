namespace Module_6_6
{
    class User
    {
        private int age;
        private string login;
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("Неправильный формат почты");
                }
                else
                {
                    email = value;
                }

            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов");
                }
                else
                {
                    login = value;
                }

            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
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
            User user = new User();

            // Setter
            user.Age = 23;
            user.Login = "as";
            user.Email = "v";

            // Getter
            Console.WriteLine(user.Age + user.Login + user.Email);

            Console.ReadKey();
        }
    }
}